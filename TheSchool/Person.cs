using System;
using System.Collections.Generic;
using System.Text;

namespace TheSchool
{
    public abstract class Person
    {
        protected string _fname;
        public string FName
        {
            get
            {
                return _fname;
            }
        }
        protected string _lname;
        public string LName
        {
            get
            {
                return _lname;
            }
        }
        protected string _phonenumber;
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

        public Person(string fname, string lname, string phonenumber)
        {
            _fname = fname;
            _lname = lname;
            _phonenumber = phonenumber;
        }

        public virtual string GiveIntro()
        {
            string intro = "Hello, my name is " + _fname + " " + _lname + ".";
            return intro;
        }
    }
}
