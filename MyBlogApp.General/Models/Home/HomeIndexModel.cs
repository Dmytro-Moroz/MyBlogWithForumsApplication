using System.Collections.Generic;
using MyBlogApp.General.Models.Post;

namespace MyBlogApp.General.Models.Home
{
    public class HomeIndexModel
    {
        public string QueryString { get; set; }
        public IEnumerable<PostListingModel> LastPosts { get; set; }
    }
}
