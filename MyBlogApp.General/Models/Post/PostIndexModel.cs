using System;
using System.Collections.Generic;
using MyBlogApp.General.Models.Reply;

namespace MyBlogApp.General.Models.Post
{
    public class PostIndexModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        public int AuthorRating { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PostContent { get; set; }
        public bool IsAuthorAdmin { get; set; }

        public int ForumId { get; set; }
        public string ForumName { get; set; }

        public IEnumerable<PostReplyModel> PostReplies { get; set; }
    }
}
