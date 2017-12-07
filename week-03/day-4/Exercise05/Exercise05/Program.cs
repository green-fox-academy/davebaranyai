using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Exercise05
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Bunnies:");
//            int bunnies = Convert.ToInt32(Console.ReadLine());
//            int counter = 1;

//            int result = EarsNum(bunnies, counter);
//            Console.WriteLine(result);
//            Console.ReadLine();
//        }
//        static int EarsNum(int bunnies, int counter)
//        {
//            if (counter > 1)
//            {
//                return bunnies;
//            }
//            else
//            {
//                return bunnies + EarsNum(bunnies, counter + 1);
//            }
//        }
//    }
//}

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bunnies:");
            int bunnies = Convert.ToInt32(Console.ReadLine());

            int result = EarsNum(bunnies);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int EarsNum(int bunnies)
        {
            if (bunnies == 1)
            {
                return 2;
            }
            else
            {
                return 2 + EarsNum(bunnies - 1);
            }
        }
    }
}