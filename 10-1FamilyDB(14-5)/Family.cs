using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1FamilyDB_14_5_
{
    /// <summary>
    /// Class: Family
    /// Developer: Melissa Bakke
    /// Date: 10/31/16
    /// Assignment: 10-1 Family Database Chapter 14-5
    /// </summary>
    class Family
    {
        #region private fields
        private string id;
        private string firstName;
        private string lastName;
        private string relationship;
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

        public string Relationship
        {
            get
            {
                return relationship;
            } // end of get
        } // end of property

        // constructors
        public Family() { }

        public Family(string fname, string lname, string rel)
        {
            firstName = fname;
            lastName = lname;
            relationship = rel;
        } // end of constuctor

        public override string ToString()
        {
            return firstName + " " + lastName + ", " + relationship;
        } // end of method
    }
}
