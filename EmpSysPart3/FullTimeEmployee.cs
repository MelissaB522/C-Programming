using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSysPart2
{
    class FullTimeEmployee : Employee
    {
        //declare variables
        private decimal salary;
        private decimal vacationDays;
        private decimal sickDays;
        private bool isTaxExempt;
        private bool hasInsurance;

        
        public FullTimeEmployee(string fname, string lname, DateTime hired, string social, string email, string phone, decimal taxrate, decimal salary, 
            decimal vacation, decimal sick, bool istaxexempt, bool hasins) : base(fname, lname, hired, social, email, phone, taxrate)
        {
            Salary = salary;
            Vacation = vacation;
            Sick = sick;
            IsTaxExempt = istaxexempt;
            HasIns = hasins;
        }

        /// <summary>
        /// Override ToString to format information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return LastName + ", " + FirstName + ", " + DateHired + ", " + Social + ", " + Email + ", " + Phone + ", " + TaxRate + ", " + Salary + ", " +
                Vacation + ", " + Sick + ", " + IsTaxExempt + ", " + HasIns;
        }

        /// <summary>
        /// Method to calculate taxes (number currently for reference)
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateTaxes()
        {
            return 3000; // TODO when given calculation
        }

        /// <summary>
        /// Method to calculate total earnings (number currently for reference)
        /// </summary>
        /// <returns></returns>
        public override decimal CalcTotalEarnings()
        {
            return 30000; // TODO when given calculation
        }

        //getters and setters
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public decimal Vacation
        {
            get { return vacationDays; }
            set { vacationDays = value; }
        }

        public decimal Sick
        {
            get { return sickDays; }
            set { sickDays = value; }
        }

        public bool IsTaxExempt
        {
            get { return isTaxExempt; }
            set { isTaxExempt = value; }
        }

        public bool HasIns
        {
            get { return hasInsurance; }
            set { hasInsurance = value; }
        }

    }//end class
}//end namespace
