﻿using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            string corrected = "";
            for (int i = reversed.Length - 1; i >= 0; i--)
            {
                corrected += reversed[i];
            }

            Console.WriteLine(corrected);
            Console.ReadLine();
        }
    }
}