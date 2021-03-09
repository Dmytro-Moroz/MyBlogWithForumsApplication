using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyBlogApp.Models;

namespace MyBlogApp.DataAccess
{
    public interface IUser
    {
        User GetUserById(string id);
        IEnumerable<User> GetAllUsers();
        Task SetProfileImage(string id, Uri uri);
        Task UpdateUserRating(string id, Type type);
    }
}
