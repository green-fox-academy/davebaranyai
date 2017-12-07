using System;

namespace ConsoleApp1
{
    class ReturnTest
    {
        static double CalculateArea(int radius)
        {
            double area = radius * radius * Math.PI;
            return area;
        }

        static void Main()
        {
            int radius = 6;
            double result = CalculateArea(radius);
            Console.WriteLine("The area is {0:0.00}", result);

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}