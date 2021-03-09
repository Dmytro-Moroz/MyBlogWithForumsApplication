using System;
using Microsoft.AspNetCore.Http;

namespace MyBlogApp.General.Models.User
{
    public class ProfileModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Rating { get; set; }
        public string ProfileImage { get; set; }
        public bool IsAdmin { get; set; }

        public DateTime MemberSince { get; set; }
        public IFormFile UploadImage { get; set; }

    }
}
