using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyBlogApp.Application.Services;
using MyBlogApp.DataAccess;
using MyBlogApp.Models;
using NUnit.Framework;

namespace MyBlogApp.Tests
{
    [TestFixture]
    public class PostServiceTests
    {
        [Test]
        public void Return_Filtered_Result_By_Query()
        {
            var options =
                new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()).Options;

            //Arrange
            using (var ctx = new ApplicationDbContext(options))
            {
                ctx.Forums.Add(new Forum
                {
                    Id = 19
                });

                ctx.Posts.Add(new Post
                {
                    Forum = ctx.Forums.Find(19),
                    Id = 1345,
                    Title = "AAA",
                    Content = "aaa"
                    //Content = "cccaaa"- for test passed
                });

                ctx.Posts.Add(new Post
                {
                    Forum = ctx.Forums.Find(19),
                    Id = 13045,
                    Title = "BBB",
                    Content = "bbb"
                    //Content = "cccbbb" - for test passed
                });

                ctx.Posts.Add(new Post
                {
                    Forum = ctx.Forums.Find(19),
                    Id = 13405,
                    Title = "CCC",
                    Content = "ccc"
                });

                ctx.SaveChanges();
            }
            //Act
            using (var ctx = new ApplicationDbContext(options))
            {
                var postService = new PostService(ctx);
                var result = postService.GetFilteredPosts("ccc");
                var postCount = result.Count();
                //Assert
                Assert.AreEqual(3, postCount);
            }


        }
    }
}
