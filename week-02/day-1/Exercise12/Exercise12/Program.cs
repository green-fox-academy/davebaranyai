﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double side1 = 8.0;
            double side2 = 11.0;
            double side3 = 9.0;

            double area = 2 * ((side1 * side2) + (side2 * side3) + (side1 * side3));
            double volume = side1 * side2 * side3;

            Console.WriteLine("Surface Area: " + area);
            Console.WriteLine("Volume: " + volume);
            Console.ReadLine();
        }

    }
}