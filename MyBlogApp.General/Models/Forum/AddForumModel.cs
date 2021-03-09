using Microsoft.AspNetCore.Http;

namespace MyBlogApp.General.Models.Forum
{
    public class AddForumModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public IFormFile ImageUpload { get; set; }
    }
}
