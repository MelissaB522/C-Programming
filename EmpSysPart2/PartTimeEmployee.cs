using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSysPart2
{
    class PartTimeEmployee : Employee
    {
        //declare variables
        private decimal hourlyRate;
        private decimal hoursWorked;

        public PartTimeEmployee(string fname, string lname, DateTime hired, string social, string email, string phone, decimal taxrate, decimal hrrate, 
            decimal hrsworked) : base(fname, lname, hired, social, email, phone, taxrate)
        {
            HourlyRate = hrrate;
            HoursWorked = hrsworked;
        }

        /// <summary>
        /// Override ToString to format information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return LastName + ", " + FirstName + ", " + DateHired + ", " + Social + ", " + Email + ", " + Phone + ", " + TaxRate + ", " + HourlyRate + ", " + HoursWorked;
        }

        /// <summary>
        /// Method to calculate taxes (number currently for reference)
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateTaxes()
        {
            return 2000; // TODO when given calculation
        }

        /// <summary>
        /// Method to calculate total earnings (number currently for reference)
        /// </summary>
        /// <returns></returns>
        public override decimal CalcTotalEarnings()
        {
            return 20000; // TODO when given calculation
        }
        
        //getters and setters
        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public decimal HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

    }//end class
}//end namespace
