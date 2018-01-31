using PallidaExam.Entities;
using PallidaExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaExam.Repositories
{
    public class CarRepository
    {
        private CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public List<Car> LicensePlateFilter(string q)
        {
            return carContext.Cars.Where(c => c.Plate.Contains(q)).ToList();
        }

	//ide johetnek pl a listak
    }
}
