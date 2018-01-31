using Microsoft.EntityFrameworkCore;
using PallidaExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaExam.Entities
{
    public class CarContext :DbContext
    {
        public CarContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Car> Books { get; set; }
    }
}
