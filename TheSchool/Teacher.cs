using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchool
{
    class Teacher : Person
    {
        #region Properties
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
            : base(aFname, aLname, aPhonenumber)
        {
            _grade = aGrade;
            _salary = aSalary;
            _hiredate = aHiredate;
        }
    }
}
