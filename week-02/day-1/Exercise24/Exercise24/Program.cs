﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints all the even numbers between 0 and 500

            for (int i = 2; i <= 500; )
            {
                Console.WriteLine(i);
                i=i + 2;
            }
            Console.ReadLine();
        }
    }
}