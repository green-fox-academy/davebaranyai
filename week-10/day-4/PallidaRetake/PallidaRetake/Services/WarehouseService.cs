using PallidaRetake.Models;
using PallidaRetake.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaRetake.Services
{
    public class WarehouseService
    {
        private WarehouseRepository warehouseRepository;

        public WarehouseService(WarehouseRepository warehouseRepository)
        {
            this.warehouseRepository = warehouseRepository;
        }
               
        public List<Item> GetAllItemsList()
        {
            return warehouseRepository.AllItemsList();
        }

        //egyeb bindzsizesek
    }
}
