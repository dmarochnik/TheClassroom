using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchool
{
    class Teacher
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
        }
        private decimal _salary;
        public decimal Salary
        {
            get
            {
                return _salary;
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
        private DateTime _hiredate;
        public DateTime Hiredate
        {
            get
            {
                return _hiredate;
            }
            set
            {
                _hiredate = value;
            }
        }
        #endregion

        public Teacher(string aFname, string aLname, int aGrade, decimal aSalary, string aPhonenumber, DateTime aHiredate)
        {
            _fname = aFname;
            _lname = aLname;
            _grade = aGrade;
            _salary = aSalary;
            _phonenumber = aPhonenumber;
            _hiredate = aHiredate;
        }

        public string GiveIntro()
        {
            string intro = "Hello, my name is " + _fname + " " + _lname + ".";
            return intro;
        }
    }
}
