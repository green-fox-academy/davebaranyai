using PallidaExam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaExam.Services
{
    public class CarService
    {
        private CarRepository carRepository;

        public CarService(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }


        //ide jonnek a bindzsizesek
    }
}
