using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchool
{
    class Classroom
    {
        private Teacher _teacher;

        private List<Student> _students;

        public Classroom(Teacher teacher)
        {
            _teacher = teacher;
            _students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void CallRoll()
        {
            Console.WriteLine(_teacher.GiveIntro());
            foreach (Student student in _students)
            {
                Console.WriteLine(student.GiveIntro());
            }
        }
    }
}
