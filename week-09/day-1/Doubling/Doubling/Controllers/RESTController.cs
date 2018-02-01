using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doubling.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class RESTController : Controller
    {
        [HttpGet("doubling")]
        public IActionResult Doubling([FromQuery]int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

    }
}