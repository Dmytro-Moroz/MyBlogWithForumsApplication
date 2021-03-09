using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlogApp.DataAccess;
using MyBlogApp.Models;

namespace MyBlogApp.Application.Services
{
    public class UserService : IUser
    {
        private readonly ApplicationDbContext Db;

        public UserService(ApplicationDbContext db)
        {
            Db = db;
        }

        public User GetUserById(string id)
        {
            return GetAllUsers().FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return Db.Users;
        }

        public async Task SetProfileImage(string id, Uri uri)
        {
            var user = GetUserById(id);
            user.UserImage = uri.AbsoluteUri;
            Db.Update(user);
            await Db.SaveChangesAsync();
        }

        public async Task UpdateUserRating(string id, Type type)
        {
            var user = GetUserById(id);
            user.Rating = GetUserRating(type, user.Rating);
            await Db.SaveChangesAsync();
        }

        private int GetUserRating(Type type, int userRating)
        {
            var increment = 0;
            if (type == typeof(Post))
            {
                increment = 1;
            }
            if (type == typeof(ReplyPost))
            {
                increment = 3;
            }
            userRating += increment;

            return userRating;
        }
    }
}
