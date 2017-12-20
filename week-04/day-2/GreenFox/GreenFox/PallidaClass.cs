using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFox
{
    class PallidaClass
    {
        public string className { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Mentor> MentorList { get; set; }

        public PallidaClass(string className)
        {
            this.className = className;
            StudentList;

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
