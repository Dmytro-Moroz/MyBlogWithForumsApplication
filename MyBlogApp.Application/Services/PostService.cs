using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlogApp.DataAccess;
using MyBlogApp.Models;

namespace MyBlogApp.Application.Services
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext Db;

        public PostService(ApplicationDbContext db)
        {
            Db = db;
        }

        public Post GetPostById(int id)
        {
            return Db.Posts.Where(p => p.Id == id)
                .Include(p => p.User)
                .Include(p => p.Forum)
                .Include(p => p.ReplyPosts).ThenInclude(repl => repl.User)
                .First();
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return Db.Posts
                .Include(p => p.User)
                .Include(p => p.ReplyPosts).ThenInclude(repl => repl.User)
                .Include(p => p.Forum);
        }

        public IEnumerable<Post> GetFilteredPosts(Forum forum, string query)
        {
            return string.IsNullOrEmpty(query) ? forum.Posts : forum.Posts.Where(p => p.Title.Contains(query) || p.Content.Contains(query));
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            var normalizedQuery = searchQuery.ToLower();
            return GetAllPosts().Where(p => p.Title.ToLower().Contains(normalizedQuery) || p.Content.ToLower().Contains(normalizedQuery));
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return Db.Forums.First(f => f.Id == id).Posts;
        }

        public IEnumerable<Post> GetLatestPosts(int posts)
        {
            return GetAllPosts().OrderByDescending(p => p.CreatedDate).Take(posts);
        }

        public string GetForumImageUrl(int id)
        {
            var post = GetPostById(id);
            return post.Forum.Image;
        }

        public async Task CreatePost(Post post)
        {
            Db.Add(post);
            await Db.SaveChangesAsync();
        }

        public async Task AddReply(ReplyPost reply)
        {
            await Db.ReplyPosts.AddAsync(reply);
            await Db.SaveChangesAsync();
        }
    }
}
