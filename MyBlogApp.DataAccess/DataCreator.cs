using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MyBlogApp.Models;

namespace MyBlogApp.DataAccess
{
    public class DataCreator
    {
        private readonly ApplicationDbContext Db;

        public DataCreator(ApplicationDbContext db)
        {
            Db = db;
        }

        public Task CreateSuperUser()
        {
            var roleStore = new RoleStore<IdentityRole>(Db);
            var userStore = new UserStore<User>(Db);
            
            var user = new User
            {
                UserName = "ForumAdmin",
                NormalizedUserName = "forumadmin",
                Email = "admin@example.com",
                NormalizedEmail = "admin@example.com",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var hasher = new PasswordHasher<User>();
            var hashPassword = hasher.HashPassword(user, "admin");
            user.PasswordHash = hashPassword;

            var isAdminRole = Db.Roles.Any(r => r.Name == "Admin");
            if (!isAdminRole)
            {
               roleStore.CreateAsync(new IdentityRole {Name = "Admin", NormalizedName = "admin"});
            }

            var isSuperUser = Db.Users.Any(u => u.NormalizedUserName == user.UserName);
            if (!isSuperUser)
            {
                userStore.CreateAsync(user);
                userStore.AddToRoleAsync(user, "Admin");
            }

            Db.SaveChangesAsync();
            return Task.CompletedTask;
        }
    }
}