using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_Oriented
{
    class Teacher : Person
    {
        private string Subject;

        public void SetSubject(string aString)
        {
            Subject = aString;
        }
        public string GetSubject()
        {
            return Subject;
        }
        public string reportDetails()
        {                  
            return "Name: " + base.GetFullName() + ", Subject: " + Subject;
        }
    }
}
