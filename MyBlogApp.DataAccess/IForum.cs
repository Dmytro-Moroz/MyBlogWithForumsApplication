using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlogApp.Models;

namespace MyBlogApp.DataAccess
{
    public interface IForum
    {
        Forum GetForumById(int id);
        IEnumerable<Forum> GetAllForums();

        Task CreateForum(Forum forum);
        IEnumerable<User> GetActiveUsers(int id);
        bool HasRecentPost(int id);
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetFilteredPosts(int forumId, string modelSearchQuery);
    }
}
