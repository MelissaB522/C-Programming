using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExample
{
    /// <summary>
    /// Class: Member
    /// Date: 10/24/2016
    /// Purpose: This class includes private 
    /// fields of identification numbers,
    /// first and last names, and local phone number.
    /// Read-only properties are included. The ToString() method 
    /// is overridden to return a formatted full name.
    /// </summary>
    public class Member
    {
        #region private fields
        private string id;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        #endregion

        public string FirstName
        {
            get
            {
                return firstName;
            } // end of get
        } // end of property

        public string LastName
        {
            get
            {
                return lastName;
            } // end of get
        } // end of property

        public string Id
        {
            get
            {
                return id;
            } // end of get
        } // end of property

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            } // end of get
        } // end of property

        // constructors
        public Member() { }

        public Member(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        } // end of constuctor

        public override string ToString()
        {
            return firstName + " " + lastName; 
        } // end of method
    } // end of class
}
