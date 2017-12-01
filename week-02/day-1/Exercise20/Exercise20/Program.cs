using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Number1: ");
            int number1 = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Number2: ");
            int number2 = Int16.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(number1);
            }
            else if (number1 < number2)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine("please type different numbers");
            }
            Console.ReadLine();
        }
    }
}