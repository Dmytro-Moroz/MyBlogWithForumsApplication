using System.Collections.Generic;
using MyBlogApp.General.Models.Post;

namespace MyBlogApp.General.Models.Search
{
    public class SearchResultModel
    {
        public IEnumerable<PostListingModel> Posts { get; set; }
        public string SearchQuery { get; set; }
        public bool EmptyStringResult { get; set; }
    }
}
