using System;
using System.Collections.Generic;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            
            Console.WriteLine(ListSummer(numberList));
            Console.ReadLine();
        }

        static int ListSummer(List<int> numberList)
        {
            int sumOfNumbers = 0;

            foreach (var item in numberList)
            {
                sumOfNumbers += item;
            }

            return sumOfNumbers;
        }
    }
}
