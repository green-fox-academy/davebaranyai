using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Yondu.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class RESTController : Controller
    {
        [HttpGet("yondu")]
        public IActionResult SpeedCalculator([FromQuery]double distance, double time)
        {
            return Json(new { Distance = distance, Time = time, Speed = (distance/time)});
        }
    }
}