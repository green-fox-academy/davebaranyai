using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;


namespace HelloWorld.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {      

        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            Greeting greeting = new Greeting(name);
            
            return new JsonResult(greeting);
        }
    }
}