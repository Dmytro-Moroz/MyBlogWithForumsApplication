using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlogApp.DataAccess;
using MyBlogApp.Models;

namespace MyBlogApp.Application.Services
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext Db;
        private readonly IPost _postService;

        public ForumService(ApplicationDbContext db, IPost postService)
        {
            Db = db;
            _postService = postService;
        }

        public Forum GetForumById(int id)
        {
            var forum = Db.Forums.Where(f => f.Id == id)
                .Include(f => f.Posts).ThenInclude(u => u.User)
                .Include(f => f.Posts).ThenInclude(p => p.ReplyPosts).ThenInclude(r => r.User)
                .FirstOrDefault();

            return forum;
        }

        public IEnumerable<Forum> GetAllForums()
        {
            return Db.Forums.Include(f => f.Posts);
        }

        public async Task CreateForum(Forum forum)
        {
            Db.Forums.Add(forum);
            await Db.SaveChangesAsync();
        }

        public IEnumerable<User> GetActiveUsers(int id)
        {
            var posts = GetForumById(id).Posts;
            if (posts != null || !posts.Any())
            {
                var postUsers = posts.Select(p => p.User);
                var replyUsers = posts.SelectMany(p => p.ReplyPosts).Select(r => r.User);

                return postUsers.Union(replyUsers).Distinct();
            }

            return new List<User>();
        }

        public bool HasRecentPost(int id)
        {
            const int hourAgo = 12;
            var window = DateTime.Now.AddHours(-hourAgo);
            return GetForumById(id).Posts.Any(p => p.CreatedDate > window);
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            return _postService.GetFilteredPosts(searchQuery);
        }

        public IEnumerable<Post> GetFilteredPosts(int forumId, string searchQuery)
        {
            if (forumId == 0)
            {
                return _postService.GetFilteredPosts(searchQuery);
            }

            var forum = GetForumById(forumId);
            return String.IsNullOrEmpty(searchQuery)
                ? forum.Posts
                : forum.Posts.Where(p => p.Title.Contains(searchQuery) || p.Content.Contains(searchQuery));
        }
    }
}
