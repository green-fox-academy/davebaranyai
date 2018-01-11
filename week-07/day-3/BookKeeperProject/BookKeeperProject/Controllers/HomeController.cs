using Microsoft.AspNetCore.Mvc;

namespace BookKeeperProject.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
