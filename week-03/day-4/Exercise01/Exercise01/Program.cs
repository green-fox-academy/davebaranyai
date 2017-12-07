using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Countdown from: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Countdown(number));
            Console.ReadLine();
        }
        public static int Countdown(int number)
        {
            if (number == 0)
            {
                return (number);
            }
            else
            {
                Console.WriteLine(number);
                return (Countdown(-- number));
            }
        }
    }
}
