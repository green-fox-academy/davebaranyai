using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Animal
    {
        public int Hunger { get; set; }
        public int Thirst { get; set; }

        public Animal()
        {
            Hunger = 50;
            Thirst = 50;
        }
    }
}
