using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchool
{
    class Program
    {
        public static void Main(string[] args)
        {
            var student1 = new Student("john", "doe", 9, new DateTime(2007, 7, 7), "850-776-3782");
            var student2 = new Student("amy", "smith", 9, new DateTime(2007, 1, 6), "850-776-3782");
            var student3 = new Student("derek", "carter", 9, new DateTime(2007, 3, 21), "850-776-3782");
            var student4 = new Student("samantha", "collins", 9, new DateTime(2007, 10, 10), "850-776-3782");
            var student5 = new Student("michael", "myers", 9, new DateTime(2006, 4, 21), "850-776-3782");
            //Console.WriteLine(student1.GiveIntro());
            var teacher1 = new Teacher("jane", "doe", 9, new decimal(60000.2), "555-555-5555", new DateTime(2000, 7, 7));
            //Console.WriteLine(teacher1.GiveIntro());
            var classroom1 = new Classroom(teacher1);
            classroom1.AddStudent(student1);
            classroom1.AddStudent(student2);
            classroom1.AddStudent(student3);
            classroom1.AddStudent(student4);
            classroom1.AddStudent(student5);
            classroom1.CallRoll();
            var admin1 = new Administration("Janitor", "Mark", "Grimes", "703-890-0999", new decimal(25000.25), new DateTime(2018, 1, 12));
            Console.WriteLine(admin1.GiveIntro());
        }
    }
}
