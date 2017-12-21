using System;

namespace Garden
{
    class Flower : Plant
    {
        public Flower(string color) : base(color)
        {
            Treshold = 5;
            AbsorbRate = 0.75;
        }
        public override void AbsorbWater(double amount)
        {
            CurrentWater += amount * AbsorbRate;
        }
    }
}