using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables

            int currentAllSecs = (currentHours * 60 * 60) + (currentMinutes * 60) + currentSeconds;
            int dayAllSecs = 24 * 60 * 60;

            int remaining = (dayAllSecs - currentAllSecs);

            Console.WriteLine("Reamining seconds from the day: " + remaining);
            Console.ReadLine();
        }
    }
}