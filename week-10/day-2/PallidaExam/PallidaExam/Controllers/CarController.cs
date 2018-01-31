using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaExam.Services;

namespace PallidaExam.Controllers
{
    [Route("")]
    public class CarController : Controller
    {
        private CarService carService;

        public CarController(CarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] string q, int police, int diplomat)
        {
            return View("index", );
        }

        [HttpGet("search/{brand}")]
        public IActionResult Index()
        {

            return View( );
        }
    }
}