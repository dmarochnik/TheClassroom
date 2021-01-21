using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchool
{
    class Program
    {
        public static void Main(string[] args)
        {
            var student = new Student("john", "doe", 9, new DateTime(2001, 7, 7), "850-776-3782");
            Console.WriteLine(student.GiveIntro());
            var teacher = new Teacher("jane", "doe", 9, new decimal(60000.2), "555-555-5555", new DateTime(2000, 7, 7));
            Console.WriteLine(teacher.GiveIntro());
        }
    }
}
