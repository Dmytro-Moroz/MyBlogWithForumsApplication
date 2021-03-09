using Microsoft.AspNetCore.Mvc;
using MyBlogApp.General.Models;
using System.Diagnostics;
using System.Linq;
using MyBlogApp.DataAccess;
using MyBlogApp.General.Models.Forum;
using MyBlogApp.General.Models.Home;
using MyBlogApp.General.Models.Post;
using MyBlogApp.Models;

namespace MyBlogApp.General.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPost _postService;

        public HomeController(IPost postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            var model = BuildHomeIndexModel();
            return View(model);
        }

        private HomeIndexModel BuildHomeIndexModel()
        {
            var lastPosts = _postService.GetLatestPosts(10);

            var posts = lastPosts.Select(p => new PostListingModel
            {
                Id = p.Id,
                Title = p.Title,
                AuthorName = p.User.UserName,
                AuthorId = p.User.Id,
                AuthorRating = p.User.Rating,
                DatePosting = p.CreatedDate.ToShortDateString(),
                RepliesCount = p.ReplyPosts.Count(),
                ForumName = p.Forum.Title,
                ForumId = p.Forum.Id,
                ForumImageUrl = _postService.GetForumImageUrl(p.Id)
            });

            var resultModel = new HomeIndexModel
            {
                LastPosts = posts
            };

            return resultModel;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
