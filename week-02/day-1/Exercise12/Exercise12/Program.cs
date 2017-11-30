using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write '1' for cuboid, '2' for cylinder, or '3' for sphere:");

            int answer = Int16.Parse(Console.ReadLine());

            if (answer == 1)
            {
                CuboidMethod();
            }
            else if (answer == 2)
            {
                CylinderMethod();
            }
            else if (answer == 3)
            {
                SphereMethod();
            }
            else
            {
                Console.WriteLine("Please, learn how to read.");
            }                   
        }
        static void CuboidMethod()
        {
            Console.WriteLine("Please write the length of side 'a' in cm: " );
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
        static void CylinderMethod()
        {
            Console.WriteLine("Please write the height of the cylinder in cm: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Please write the length of the radius (half of the diameter) of the cylinder in cm: ");
            double radius = double.Parse(Console.ReadLine());            
        
            double area = (2 * height * radius * Math.PI) + (2 * Math.Pow(radius, 2) * Math.PI);
            double volume = height * Math.Pow(radius, 2) * Math.PI;

            Console.WriteLine("Surface Area: " + area + " cm2");
            Console.WriteLine("Volume: " + volume + " cm3");
            Console.ReadLine();
        }
        static void SphereMethod()
        {
            Console.WriteLine("Please write the length of the radius (half of the diameter) of the sphere in cm: ");
            double radius = double.Parse(Console.ReadLine());

            double area = 4 * Math.Pow(radius, 2) * Math.PI;
            double volume = (4 * Math.Pow(radius, 3) * Math.PI) / 3;

            Console.WriteLine("Surface Area: " + area + " cm2");
            Console.WriteLine("Volume: " + volume + " cm3");
            Console.ReadLine();
        }
    }
}