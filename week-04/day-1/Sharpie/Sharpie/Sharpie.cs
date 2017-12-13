using System;
using System.Collections.Generic;
using System.Text;

namespace Sharpie
{
    class Sharpie
    {
        public string Color { get; set; }
        public double Width { get; set; }
        public double InkAmount { get; set; }
        
        public Sharpie()
        {
            InkAmount = 100;
        }
        public void Use()
        {
            InkAmount -= 1;
        }
    }
}
