using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    public class Person
    {
        //declare variables
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;

        public Person () //constructor with 0 arguments
        {

        }

        //constructor with 4 arguments
        public Person(string id, string lname, string fname, int anAge)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = anAge;
        }

        //constructor with 3 arguments
        public Person (string id, string fname, string lname)
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
        }

        //constructor with 1 argument
        public Person(string id)
        {
            idNumber = id;
        }

        //Read only property. First name cannot be changed.
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        //Property for last name
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        public virtual int GetSleepAmt()
        {
            return 8;
        }

    }//end class
}//end namespace
