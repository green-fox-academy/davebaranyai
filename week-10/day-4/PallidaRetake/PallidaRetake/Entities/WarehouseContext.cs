using Microsoft.EntityFrameworkCore;
using PallidaRetake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaRetake.Entities
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Item> ItemsTable { get; set; }
    }
}
