using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.
            int number = 14;

            if ((number % 2) == 0)
            {
                Console.WriteLine("EVEN");
            }
            else
            {
                Console.WriteLine("ODD");
            }
            Console.ReadLine();
        }
    }
}