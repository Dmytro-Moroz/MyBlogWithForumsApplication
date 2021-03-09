using System.Collections.Generic;

namespace MyBlogApp.General.Models.User
{
    public class ProfileListModel
    {
        public IEnumerable<ProfileModel> Profiles { get; set; }
    }
}
