using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlogApp.Models;

namespace MyBlogApp.DataAccess
{
    public interface IPost
    {
        Post GetPostById(int id);
        IEnumerable<Post> GetAllPosts();
        IEnumerable<Post> GetFilteredPosts(Forum forum, string query);
        IEnumerable<Post> GetFilteredPosts(string query);
        IEnumerable<Post> GetPostsByForum(int id);
        IEnumerable<Post> GetLatestPosts(int posts);

        string GetForumImageUrl(int id);

        Task CreatePost(Post post);
        Task AddReply(ReplyPost reply);
    }
}
