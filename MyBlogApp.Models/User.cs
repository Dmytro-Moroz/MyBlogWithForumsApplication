using System;
using Microsoft.AspNetCore.Identity;

namespace MyBlogApp.Models
{
    public class User : IdentityUser
    {
        public int Rating { get; set; }
        public string UserImage { get; set; }
        public DateTime UserCreated { get; set; }
        public bool IsActive { get; set; }
    }
}
