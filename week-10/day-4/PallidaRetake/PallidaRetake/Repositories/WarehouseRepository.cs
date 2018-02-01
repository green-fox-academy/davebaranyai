using PallidaRetake.Entities;
using PallidaRetake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaRetake.Repositories
{
    public class WarehouseRepository
    {
        private WarehouseContext warehouseContext;

        public WarehouseRepository(WarehouseContext warehouseContext)
        {
            this.warehouseContext = warehouseContext;
        }

        public List<Item> AllItemsList()
        {            
                return warehouseContext.ItemsTable.ToList();          
        }

	//ide johetnek pl a listak
    }
}
