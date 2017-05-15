using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    public class Student : Person //Student is derived from Person
    {
        //declare variables
        private string major;
        private string studentId;

        //default constructor
        public Student()
            : base() //No argument sent to the base class constructor
        {

        }

        //Constructor sents three arguments to base class constructor
        public Student (string id, string fname, string lname, string maj, string sId)
            : base (id, fname, lname) //base constructor arguments
        {
            major = maj;
            studentId = sId;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetSleepAmt()
        {
            return 6;
        }
    }//end class
}//end namespace
