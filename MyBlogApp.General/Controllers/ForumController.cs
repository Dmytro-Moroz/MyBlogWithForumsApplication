using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;
using Microsoft.WindowsAzure.Storage.Blob;
using MyBlogApp.DataAccess;
using MyBlogApp.General.Models.Forum;
using MyBlogApp.General.Models.Post;
using MyBlogApp.Models;

namespace MyBlogApp.General.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumRepository;
        private readonly IPost _postRepository;
        private readonly IConfiguration _configuration;
        private readonly IUpload _uploadService;

        public ForumController(IForum forumRepository, IPost postRepository, IConfiguration configuration, IUpload uploadService)
        {
            _forumRepository = forumRepository;
            _postRepository = postRepository;
            _configuration = configuration;
            _uploadService = uploadService;
        }

        public IActionResult Index()
        {
            var forums = _forumRepository.GetAllForums().Select(f => new ForumListingModel
            {
                Id = f.Id,
                Name = f.Title,
                Description = f.Description,
                PostsCount = f.Posts?.Count() ?? 0,
                UsersCount = _forumRepository.GetActiveUsers(f.Id).Count(),
                ForumImage = f.Image,
                HasRecentPost = _forumRepository.HasRecentPost(f.Id)
            });

            var model = new ForumIndexModel
            {
                ForumListing = forums.OrderBy(f => f.PostsCount)
            };

            return View(model);
        }

        public IActionResult Topic(int id, string searchQuery)
        {
            var forum = _forumRepository.GetForumById(id);
            var posts = _forumRepository.GetFilteredPosts(id, searchQuery).ToList();
            var noResults = (!string.IsNullOrEmpty(searchQuery) && !posts.Any());

            var postLists = posts.Select(p => new PostListingModel
            {
                Id = p.Id,
                AuthorId = p.User.Id,
                AuthorRating = p.User.Rating,
                AuthorName = p.User.UserName,
                Title = p.Title,
                DatePosting = p.CreatedDate.ToShortDateString(),
                RepliesCount = p.ReplyPosts.Count(),
                Forum = ForumBuildingList(p)
            });
            var model = new ForumTopicModel
            {
                Posts = postLists,
                Forum = ForumBuildingList(forum),
                SearchQuery = searchQuery,
                EmptySearchResults = noResults
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Search(int id, string searchQuery)
        {
            return RedirectToAction("Topic", new {id, searchQuery});
        }

        [Authorize(Roles = "Admin")]
        public IActionResult CreateForum()
        {
            var model =  new AddForumModel();
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddForum(AddForumModel model)
        {
            var imageUri = "/images/theme/unnamed.png";
            if (model.ImageUpload != null)
            {
                var blockBlob = PostForumImage(model.ImageUpload);
                imageUri = blockBlob.Uri.AbsoluteUri;
            }

            var forum = new Forum
            {
                Title = model.Title,
                Description = model.Description,
                CreatedDate = DateTime.Now,
                Image = imageUri
            };
            await _forumRepository.CreateForum(forum);
            return RedirectToAction("Index", "Forum");
        }

        private CloudBlockBlob PostForumImage(IFormFile file)
        {
            var connectionString = _configuration.GetConnectionString("AzureStorage");
            var container = _uploadService.GetBlobContainer(connectionString, "forum-images");
            var parsedContentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
            var fileName = Path.Combine(parsedContentDisposition.FileName.ToString().Trim('"'));
            var blockBlob = container.GetBlockBlobReference(fileName);
            blockBlob.UploadFromStreamAsync(file.OpenReadStream()).Wait();
            return blockBlob;
        }

        private ForumListingModel ForumBuildingList(Post post)
        {
            var forum = post.Forum;
            return ForumBuildingList(forum);
        }

        private ForumListingModel ForumBuildingList(Forum forum)
        {
            var forumList = new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ForumImage = forum.Image
            };
            return forumList;
        }
    }
}