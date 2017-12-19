using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Student : Person
    {
        string previousOrganization;
        int skippedDays;

        public Student(string previousOrganization, int skippedDays)
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ",a(n) " + age + " year old " + gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.");
        }

        public int SkipDays(int numberOfDays, int skippedDays)
        {
            return skippedDays = skippedDays + numberOfDays;
        }
    }
}
