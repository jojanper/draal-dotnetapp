
using Microsoft.AspNetCore.Mvc;

namespace draal.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        public string Get()
        {
            return "hello";
        }
    }
}