using System.Web.Http;
using CoolBlogAPI.Models;

namespace CoolBlogAPI.Controllers
{
    public class RatingController : ApiController
    {
        public Rating GetRating(int id)
        {
            return new Rating {UpvoteCount = 100, DownvoteCount = 50};
        }

        [HttpGet]
        [Route("api/rating/{id}/upvote")]
        public IHttpActionResult Upvote(int id)
        {
            return Ok("I upvoted" + id);
        }

        [HttpGet]
        [Route("api/rating/{id}/downvote")]
        public IHttpActionResult Downvote(int id)
        {
            return Ok("I downvoted" + id);
        }
    }
}
