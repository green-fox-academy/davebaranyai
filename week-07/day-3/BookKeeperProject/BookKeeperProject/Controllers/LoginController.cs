using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace BookKeeperProject.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            if (name.Equals("David"))
            {
                return Ok();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
