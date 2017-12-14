using System;

namespace Exercise27
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxNumber = 101;
            FizzBuzzer(MaxNumber);
            Console.ReadLine();
        }        
        static void FizzBuzzer(int MaxNumber)
        {
            for (int i = 1; i < MaxNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }            
        }
    }
}
