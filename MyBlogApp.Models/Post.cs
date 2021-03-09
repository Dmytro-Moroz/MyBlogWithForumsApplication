using System;
using System.Collections.Generic;

namespace MyBlogApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User User { get; set; }
        public virtual Forum Forum { get; set; }
        public virtual IEnumerable<ReplyPost> ReplyPosts { get; set; }
    }
}
