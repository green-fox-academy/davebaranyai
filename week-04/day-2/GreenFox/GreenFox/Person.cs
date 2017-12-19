using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class Person
    {
        public string name;
        public int age;
        public string gender;

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a(n) " + age + " year old " + gender + ".");
        }

        public void GetGoal()
        {
            Console.WriteLine(@"My goal is: Live for the moment!");
        }
    }
}
