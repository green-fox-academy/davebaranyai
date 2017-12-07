using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Numberadder (number);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int Numberadder(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number + Numberadder(number - 1);               
            }
        }
    }
}
