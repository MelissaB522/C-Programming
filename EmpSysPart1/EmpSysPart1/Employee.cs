using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSysPart1
{
    class Employee
    {
        //declare variables
        private string firstName;
        private string lastName;
        private DateTime dateHired;
        private string socialSecurityNum;
        private string emailAddress;
        private string phoneNum;
        private decimal taxRate;

        //main constructor
        public Employee(string fname, string lname, DateTime hired, string social, string email, string phone, decimal taxrate)
        {
            FirstName = fname;
            LastName = lname;
            DateHired = hired;
            Social = social;
            Email = email;
            Phone = phone;
            TaxRate = taxrate;
        }

        //default constructor
        public Employee()
        {
        }

        /// <summary>
        /// Override ToString to format information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return LastName + ", " + FirstName + ", " + DateHired.Month + "/" + DateHired.Day + "/" + DateHired.Year + ", " + Social + ", " + Email + ", " + Phone + ", " + TaxRate;
        }

        /// <summary>
        /// Method to calculate taxes (number currently for reference)
        /// </summary>
        /// <returns></returns>
        public virtual decimal CalculateTaxes()
        {
            return 1000; // TODO when given calculation
        }

        /// <summary>
        /// Method to calculate total earnings (number currently for reference)
        /// </summary>
        /// <returns></returns>
        public virtual decimal CalcTotalEarnings()
        {
            return 10000; // TODO when given calculation
        }

        //getters and setters
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime DateHired
        {
            get { return dateHired; }
            set { dateHired = value; }
        }

        public string Social
        {
            get
            {
                string LastFourDigitSSN = socialSecurityNum.Substring(7, 4);
                return "XXX-XX-" + LastFourDigitSSN; //only shows last 4 digits of SSN
            }
            set { socialSecurityNum = value; }
        }

        public string Email
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public string Phone
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public decimal TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }

    }//end class
}//end namespace
