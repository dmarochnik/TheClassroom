using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchool
{
    class Administration : Person
    {
        #region Properties
        private string _title;
        public string Title
        {
            get
            {
                return _title;
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
        }
        #endregion

        public Administration(string title, string fname, string lname, string phonenumber, decimal salary, DateTime hiredate)
            :base(fname, lname, phonenumber)
        {
            _title = title;
            _salary = salary;
            _hiredate = hiredate;
        }
        public override string GiveIntro()
        {
            var years = (int)(DateTime.Now.Subtract(_hiredate).TotalDays / 365);
            string intro = "Hello, my name is " + _fname + " " +  _lname + ", I am a " + _title + " and I have worked here for " + years + " years.";
            return intro;
        }

    }   
}
