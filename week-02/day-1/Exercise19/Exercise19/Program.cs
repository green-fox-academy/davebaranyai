
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
            Console.WriteLine("Number: ");
            int Input = Int16.Parse(Console.ReadLine());
            if (Input <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (Input == 1)
            {
                Console.WriteLine("One");
            }
            else if (Input == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A Lot");
            }
            Console.ReadLine();
        }
    }
}