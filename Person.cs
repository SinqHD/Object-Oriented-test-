using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_Oriented
{
    class Person
    {
         //Internal properties/attributes (variables)
        private string mFirstName;
        private string mLastName;
        private int age;

        //Public methods/behaviours (functions)
        public void SetAge(int Number1)
        {
            age = Number1;
        }

        public int GetAge()
        {
            return age;
        }
        public void SetFirstName(string Value)
        {
            //assign Value to internal variable from the outside world
            mFirstName = Value;
        }

        public string GetFirstName()
        {
            //retreive internal variable and expose to outside world
            return mFirstName;
        }

        public void SetLastName(string Value)
        {
            //assign Value to internal variable from the outside world
            mLastName = Value;
        }

        public string GetLastName()
        {
            //retreive internal variable and expose to outside world
            return mLastName;
        }


        public string GetFullName()
        {
            //retreives the persons full name
            return mFirstName + " " + mLastName;
        }
    }
}
