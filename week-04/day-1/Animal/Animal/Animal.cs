using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Animal
    {
        public int Hunger { get; set; } = 50;
        public int Thirst { get; set; } = 50;

        //public Animal()
        //{
        //    Hunger = 50;
        //    Thirst = 50;
        //}
        public void Eat()
        {
            Hunger -= 1;
        }
        public void Drink()
        {
            Thirst -= 1;
        }
        public void Play()
        {
            Hunger += 1;
            Thirst += 1;
        }


    }
}
