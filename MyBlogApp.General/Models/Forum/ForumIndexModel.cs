using System.Collections.Generic;

namespace MyBlogApp.General.Models.Forum
{
    public class ForumIndexModel
    {
        public IEnumerable<ForumListingModel> ForumListing { get; set; }
    }
}
