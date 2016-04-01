using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CoolBlogAPI.Models;

namespace CoolBlogAPI.Controllers
{
    public class BlogController : ApiController
    {
        public Blog[] GetBlogs()
        {
            var blog = new Blog
            {
                AuthorId = 1,
                Content = "this is content",
                CreationTime = DateTime.Now,
                Title = "this is title"
            };

            return new[] {blog};
        }

        public Blog GetBlog(int id)
        {
            var blog = new Blog
            {
                AuthorId = 1,
                Content = "this is content",
                CreationTime = DateTime.Now,
                Title = "this is title"
            };

            return blog;
        }

        public IHttpActionResult PostBlog(Blog blog)
        {
            return Ok("I did it");
        } 
    }
}
