using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MyBlogApp.DataAccess;
using MyBlogApp.General.Models.Forum;
using MyBlogApp.General.Models.Post;
using MyBlogApp.General.Models.Search;
using MyBlogApp.Models;

namespace MyBlogApp.General.Controllers
{
    public class SearchController : Controller
    {
        private readonly IPost _postRepository;

        public SearchController(IPost postRepository)
        {
            _postRepository = postRepository;
        }

        public IActionResult Results(string query)
        {
            var posts = _postRepository.GetFilteredPosts(query).ToList();
            var emptyString = (!string.IsNullOrEmpty(query) && !posts.Any());
            var postsList = posts.Select(p => new PostListingModel
            {
                Id = p.Id,
                AuthorId = p.User.Id,
                AuthorName = p.User.UserName,
                AuthorRating = p.User.Rating,
                Title = p.Title,
                DatePosting = p.CreatedDate.ToShortDateString(),
                RepliesCount = p.ReplyPosts.Count(),
                Forum = BuildForumList(p)
            });
            var model = new SearchResultModel
            {
                Posts = postsList,
                SearchQuery = query,
                EmptyStringResult = emptyString
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Search(string searchQuery)
        {
            return RedirectToAction("Results", new { searchQuery });
        }

        private ForumListingModel BuildForumList(Post post)
        {
            var forum = post.Forum;
            return new ForumListingModel
            {
                Id = forum.Id,
                Description = forum.Description,
                ForumImage = forum.Image,
                Name = forum.Title
            };
        }
    }
}
