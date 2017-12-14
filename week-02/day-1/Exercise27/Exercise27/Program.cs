using System;

namespace Exercise27
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer(Result);
            Console.ReadLine();
        }
        static int Counter()
        {
            for (int i = 1; i < 101; i++)
            {
                return i;
            }            
        }
        static void FizzBuzzer(int Result)
        {
            if (Result % 3 == 0 && Result % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (Result % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (Result % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(Result);
            }
        }
    }
}
