using System;

namespace MyBlogApp.Models
{
    public class ReplyPost
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}
