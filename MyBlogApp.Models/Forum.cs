using System;
using System.Collections.Generic;

namespace MyBlogApp.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Image { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
