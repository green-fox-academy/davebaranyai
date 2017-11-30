using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("How many kilometres do you want to convert?");
            double kilometers = Console.Read();
            double miles = kilometers * 0.62137;
            Console.WriteLine(kilometers + " kilometers are " + miles + " miles");
            Console.ReadKey();
        }
    }
}