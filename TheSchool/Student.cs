using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchool
{
    public class Student : Person
    {
        #region Properties
        private int _grade;
        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                _grade = value;
            }
        }
        private DateTime _birthdate;
        public DateTime Birthdate
        {
            get
            {
                return _birthdate;
            }
        }
        #endregion

        public Student(string aFname, string aLname, int aGrade, DateTime aBirthdate, string aPhonenumber)
            :base(aFname, aLname, aPhonenumber)
        {
            _grade = aGrade;
            _birthdate = aBirthdate;
        }

        public override string GiveIntro()
        {
            var today = DateTime.Today;
            int age = (int)(today.Subtract(_birthdate).TotalDays / 365);
            string intro = "Hello, my name is " + _fname + " " + _lname + " and I am " + age + " years old.";
            return intro;
        }
    }
}
