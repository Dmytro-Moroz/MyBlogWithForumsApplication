namespace MyBlogApp.General.Models.Forum
{
    public class ForumListingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ForumImage { get; set; }

        public int PostsCount { get; set; }
        public int UsersCount { get; set; }
        public bool HasRecentPost { get; set; }
    }
}
