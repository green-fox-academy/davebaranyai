using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            int avghrsperday = 6;
            int semesterweeks = 17;
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            Console.WriteLine((semesterweeks * 5) * avghrsperday);
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            Console.WriteLine((double)(avghrsperday * 5) / 52 * 100);
            Console.ReadLine();
        }
    }
}