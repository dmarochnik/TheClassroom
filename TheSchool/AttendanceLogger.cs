using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TheSchool
{
    class AttendanceLogger
    {
        private List<AttendanceLog> _log;

        public AttendanceLogger()
        {
            _log = new List<AttendanceLog>();
        }

        public void AddLog(Person person, bool present)
        {
            _log.Add(new AttendanceLog(person, present));
        }
    }

    class AttendanceLog
    {
        private Person _person;
        public Person Person
        {
            get
            {
                return _person;
            }
        }

        private bool _present;
        public bool Present
        {
            get
            {
                return _present;
            }
        }

        // TODO: add date

        public AttendanceLog(Person person, bool present)
        {
            _person = person;
            _present = present;
        }
    }
}
