using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the length of side 'a' in cm: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write the length of side 'b' in cm: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write the length of side 'c' in cm: ");
            double sideC = double.Parse(Console.ReadLine());

            double area = 2 * ((sideA * sideB) + (sideB * sideC) + (sideA * sideC));
            double volume = sideA * sideB * sideC;

            Console.WriteLine("Surface Area: " + area + " cm2");
            Console.WriteLine("Volume: " + volume + " cm3");
            Console.ReadLine();
        }
    }
}
