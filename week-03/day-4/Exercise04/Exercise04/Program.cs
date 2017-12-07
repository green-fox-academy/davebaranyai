using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base:");
            int basenum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PowerN:");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Power(basenum, n);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int Power(int basenum, int n)
        {
            if (basenum == 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                return basenum * Power(basenum, --n);
            }
        }
    }
}