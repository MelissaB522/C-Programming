using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1FamilyDBSer
{
    /// <summary>
    /// Class: Family
    /// Developer: Melissa Bakke
    /// Date: 11/22/16
    /// Assignment: 13-1 Family Database Serialized
    /// </summary>
    [Serializable]
    class Family
    {
        private string id;
        private string firstName;
        private string lastName;
        private string relationship;

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

        public void Add()
        {
            string serializedData = Serializer.SerializeNow(this);
        }
    }
}
