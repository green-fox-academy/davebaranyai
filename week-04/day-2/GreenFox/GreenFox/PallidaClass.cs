using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class PallidaClass
    {
        string className;
        public List<Student> StudentList;
        public List<Mentor> MentorList;

        public PallidaClass(string className)
            {
            this.className = className;
        }

        public void AddStudent(Student OneStudent)
        {
            StudentList.Add(OneStudent);
        }

        public void AddMentor(Mentor OneMentor)
        {
            MentorList.Add(OneMentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida" + className + "class has " + StudentList.Count + " students and " + MentorList.Count + " mentors.");
        }

    }
}
