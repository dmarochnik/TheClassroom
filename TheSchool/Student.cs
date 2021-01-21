using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchool
{
    public class Student
    {
        #region Properties
        private string _fname;
        public string FName
        {
            get
            {
                return _fname;
            }
        }
        private string _lname;
        public string LName
        {
            get
            {
                return _lname;
            }
        }
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
        private string _phonenumber;
        public string Phonenumber
        {
            get
            {
                return _phonenumber;
            }
            set
            {
                _phonenumber = value;
            }
        }
        #endregion

        public Student(string aFname, string aLname, int aGrade, DateTime aBirthdate, string aPhonenumber)
        {
            _fname = aFname;
            _lname = aLname;
            _grade = aGrade;
            _birthdate = aBirthdate;
            _phonenumber = aPhonenumber;
        }

        public string GiveIntro()
        {
            var today = DateTime.Today;
            int age = (int)(today.Subtract(_birthdate).TotalDays / 365);
            string intro = "Hello, my name is " + _fname + " " + _lname + " and I am " + age + " years old.";
            return intro;
        }
    }
}
