using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Sumdigit(number);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int Sumdigit(int number)
        {
            if (number < 10)
            {
                return number;
            }
            else
            {
                return (number % 10) + Sumdigit(number / 10);
            }
        }
    }
}