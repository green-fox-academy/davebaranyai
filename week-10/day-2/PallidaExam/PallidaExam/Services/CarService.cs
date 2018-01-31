using PallidaExam.Models;
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

        public List<Car> GetSearchList(string q, int police, int diplomat)
        {   
            if (q != null)
            {
                return carRepository.LicensePlateFilter(q);
            }
            else if (police == 1)
            {
                return carRepository.PoliceFilter();
            }
            else if (diplomat == 1)
            {
                return carRepository.DiplomatFilter();
            }

            return null;
        }

        

        //ide jonnek a bindzsizesek
    }
}
