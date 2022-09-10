using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_Oriented
{
    class Student : Person
    {
        //Student : Person
        //Inherits a from the class Person

        //private data variables
        private string Grade;
        private string StudentNo;

        public void SetStudentNo(string aStudentNum)
        {
            StudentNo = aStudentNum;
        }

        public string GetStudentNo()
        {
            return StudentNo;
        }
        public void SetGrade(string sGrade)
        {
            //assign Value to internal variable from the outside world
            Grade = sGrade;
        }

        public string GetGrade()
        {
            //retreive internal variable and expose to outside world
            return Grade;
        }

        public string GetStudentRecord()
        {
            //retreive internal variable and call a method from the super class Person                        
            return "Name: " + base.GetFullName() + ", Grade: " + Grade;

        }
    }
}
