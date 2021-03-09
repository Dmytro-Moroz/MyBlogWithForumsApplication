using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogApp.DataAccess;
using MyBlogApp.General.Models.Reply;
using MyBlogApp.Models;

namespace MyBlogApp.General.Controllers
{
    [Authorize]
    public class ReplyController : Controller
    {
        private readonly IPost _postService;
        private readonly UserManager<User> _userManager;
        private readonly IUser _userService;

        public ReplyController(IPost postService, UserManager<User> userManager, IUser userService)
        {
            _postService = postService;
            _userManager = userManager;
            _userService = userService;
        }

        public async Task<IActionResult> CreateReply(int id)
        {
            var post = _postService.GetPostById(id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var model = new PostReplyModel
            {
                PostId = post.Id,
                PostTitle = post.Title,
                PostContent = post.Content,
                AuthorId = user.Id,
                AuthorName = user.UserName,
                AuthorImage = user.UserImage,
                AuthorRating = user.Rating,
                IsAuthorAdmin = User.IsInRole("Admin"),
                CreatedDate = DateTime.Now,
                ForumId = post.Forum.Id,
                ForumName = post.Forum.Title,
                ForumImage = post.Forum.Image
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReply(PostReplyModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var reply = BuildReply(model, user);

            await _postService.AddReply(reply);
            await _userService.UpdateUserRating(userId, typeof(ReplyPost));
            return RedirectToAction("Index", "Post", new {id = model.PostId});
        }

        private ReplyPost BuildReply(PostReplyModel model, User user)
        {
            var post = _postService.GetPostById(model.PostId);
            return new ReplyPost
            {
                Post = post,
                Content = model.ReplyContent,
                CreatedDate = DateTime.Now,
                User = user
            };
        }
    }
}