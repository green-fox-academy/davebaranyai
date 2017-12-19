using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Mentor : Person
    {
        string level;

        public Mentor(string level)
        {
            level = "intermediate";
        }

        public new void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ",a(n) " + age + " year old " + gender + " " + level + " mentor.");
        }
    }
}
