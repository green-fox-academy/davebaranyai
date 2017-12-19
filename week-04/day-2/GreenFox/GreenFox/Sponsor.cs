using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Sponsor : Person
    {
        string company;
        int hiredStudents;

        public Sponsor(string company, int hiredStudents)
        {
            company = "Google";
            hiredStudents = 0;
        }

        public new void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " who represents " + company + " and hired " + hiredStudents + " students so far.");
        }

        public int Hire(int hiredStudents)
        {
            return hiredStudents++;
        }
    }
}
