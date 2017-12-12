using System;
using System.Collections.Generic;
using System.Text;

namespace Practicing_stuff
{
    class Player
    {
        private int lives = 100;

        public int Lives
        {
            get
            {
                return lives;
            }
            set
            {
                //if (value <= 0 || value >= 1000)
                //{
                //    Console.WriteLine("Makes no sense.");
                //    return;
                //}
                lives = value;
            }
        }
    }
}
