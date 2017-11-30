using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
            Console.WriteLine("How many chickens do you have?");
            int chick = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many pigs do you have?");
            int pig = Int32.Parse(Console.ReadLine());

            int legstotal = (chick * 2) + (pig * 4); 
            Console.WriteLine("Total legs of your animals: " + legstotal);

            Console.ReadLine();
        }
    }
}