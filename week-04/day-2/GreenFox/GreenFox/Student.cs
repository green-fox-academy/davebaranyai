using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Student : Person
    {
        string previousOrganization;
        int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student()
        {
            previousOrganization = "The School of Life";
        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ",a(n) " + age + " year old " + gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays = skippedDays + numberOfDays;
        }
    }
}
