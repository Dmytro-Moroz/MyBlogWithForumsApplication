using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlogApp.DataAccess;
using MyBlogApp.General.Models.Post;
using MyBlogApp.General.Models.Reply;
using MyBlogApp.Models;

namespace MyBlogApp.General.Controllers
{
    [Authorize]
    public class PostController : Controller
    {
        private readonly IPost _postService;
        private readonly IForum _forumService;
        private readonly UserManager<User> _userManager;
        private readonly IUser _userService;

        public PostController(IPost postService, IForum forumService, UserManager<User> userManager, IUser userService)
        {
            _postService = postService;
            _forumService = forumService;
            _userManager = userManager;
            _userService = userService;
        }

        public IActionResult Index(int id)
        {
            var post = _postService.GetPostById(id);
            var replies = BuildPostReplies(post.ReplyPosts);
            var model = new PostIndexModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorRating = post.User.Rating,
                AuthorImage = post.User.UserImage,
                IsAuthorAdmin = IsAuthorAdmin(post.User),
                CreatedDate = post.CreatedDate,
                PostContent = post.Content,
                PostReplies = replies,
                ForumId = post.Forum.Id,
                ForumName = post.Forum.Title,
            };
            return View(model);
        }

        public bool IsAuthorAdmin(User user)
        {
            return _userManager.GetRolesAsync(user).Result.Contains("Admin");
        }

        public IEnumerable<PostReplyModel> BuildPostReplies(IEnumerable<ReplyPost> postReplyPosts)
        {
            return postReplyPosts.Select(r => new PostReplyModel
            {
                Id = r.Id,
                AuthorId = r.User.Id,
                AuthorName = r.User.UserName,
                AuthorRating = r.User.Rating,
                AuthorImage = r.User.UserImage,
                CreatedDate = r.CreatedDate,
                ReplyContent = r.Content,
                IsAuthorAdmin = IsAuthorAdmin(r.User)
            });
        }

        [Authorize]
        public IActionResult CreatePost(int forumId, Forum forumEntity)
        {
            var forum = _forumService.GetForumById(forumEntity.Id);
            if (forum != null)
            {
                if (User.Identity != null)
                {
                    var model = new NewPostModel
                    {
                        ForumName = forum.Title,
                        ForumId = forum.Id,
                        AuthorName = User.Identity.Name,
                        ForumImage = forum.Image
                    };
                    return View(model);
                }
            }

            return Content("Something wrong, we have an error!");
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(NewPostModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            var post = BuildPost(model, user);

            await _postService.CreatePost(post);
            await _userService.UpdateUserRating(userId, typeof(Post));
            return RedirectToAction("Index", "Post", new {id = post.Id});
        }

        private Post BuildPost(NewPostModel model, User user)
        {
            var forum = _forumService.GetForumById(model.ForumId);
            return new Post
            {
                Title = model.Title,
                Content = model.Content,
                CreatedDate = DateTime.Now,
                User = user,
                Forum = forum
            };
        }
    }
}