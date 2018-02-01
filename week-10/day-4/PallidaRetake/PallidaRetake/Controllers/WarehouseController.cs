using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PallidaRetake.Services;

namespace PallidaRetake.Controllers
{
    [Route("")]
    public class WarehouseController : Controller
    {
        private WarehouseService warehouseService;

        public WarehouseController(WarehouseService warehouseService)
        {
            this.warehouseService = warehouseService;
        }

        [HttpGet("warehouse")]
        public IActionResult ItemListing()
        {
            return View("ItemListing", warehouseService.GetAllItemsList());
        }

        [HttpGet("warehouse/summary")]
        public IActionResult OrderSummary()
        {
            return View("OrderSummary");
        }
    }
}