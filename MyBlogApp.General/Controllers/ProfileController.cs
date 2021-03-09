using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;
using MyBlogApp.DataAccess;
using MyBlogApp.General.Models.User;
using MyBlogApp.Models;

namespace MyBlogApp.General.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IUser _userService;
        private readonly IUpload _uploadService;
        private readonly IConfiguration _configuration;

        public ProfileController(UserManager<User> userManager, IUser user, IUpload upload, IConfiguration configuration)
        {
            _userManager = userManager;
            _userService = user;
            _uploadService = upload;
            _configuration = configuration;
        }

        public IActionResult Detail(string id)
        {
            var user = _userService.GetUserById(id);
            var userRoles = _userManager.GetRolesAsync(user).Result;
            var model = new ProfileModel
            {
                UserId = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Rating = user.Rating.ToString(),
                ProfileImage = user.UserImage,
                MemberSince = user.UserCreated,
                IsAdmin = userRoles.Contains("Admin")
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UploadProfileImage(IFormFile file)
        {
            var userId = _userManager.GetUserId(User);
            var connectionString = _configuration.GetConnectionString("AzureStorage");
            var container = _uploadService.GetBlobContainer(connectionString, "profile-images");
            var contentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
            var fileName = contentDisposition.FileName.ToString().Trim('"');
            var blockBlob = container.GetBlockBlobReference(fileName);
            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());
            await _userService.SetProfileImage(userId, blockBlob.Uri);

            return RedirectToAction("Detail", "Profile", new {id = userId});
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var profiles = _userService.GetAllUsers().OrderByDescending(u => u.Rating).Select(u => new ProfileModel
            {
                Email = u.Email,
                UserName = u.UserName,
                ProfileImage = u.UserImage,
                Rating = u.Rating.ToString(),
                MemberSince = u.UserCreated
            });
            var model = new ProfileListModel
            {
                Profiles = profiles
            };
            return View(model);
        }
    }
}
