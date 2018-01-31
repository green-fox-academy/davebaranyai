using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaExam.Models
{
    public class Car
    {
        [Key]
        public string Plate { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }        
    }
}
