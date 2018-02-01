using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PallidaRetake.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class RESTController : Controller
    {
        [HttpGet("warehouse/query")]
        public IActionResult PriceComparison([FromQuery]int price, string comparison)
        {            
            return Json(new { });
        }

    }
}