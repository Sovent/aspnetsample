using System.Web.Http;

namespace CoolBlogAPI.Controllers
{
    public class HomeController : ApiController
    {
        public string GetSomething()
        {
            return "Something";
        }
    }
}
