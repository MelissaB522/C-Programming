using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSysPart2
{
    class Manager : FullTimeEmployee
    {
        //declare variables
        private decimal bonusEarned;
        private string department;
        private string office;

        public Manager(string fname, string lname, DateTime hired, string social, string email, string phone, decimal taxrate, decimal salary, 
            decimal vacation, decimal sick, bool taxexempt, bool hasins, decimal bonus, string dept, string office) : base(fname, lname, hired, social, email, phone, taxrate, salary, vacation, sick, taxexempt, hasins)
        {
            Bonus = bonus;
            Dept = dept;
            Office = office;
        }

        /// <summary>
        /// Override ToString to format information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return LastName + ", " + FirstName + ", " + DateHired + ", " + Social + ", " + Email + ", " + Phone + ", " + TaxRate + ", " + Salary + ", " +
                Vacation + ", " + Sick + ", " + IsTaxExempt + ", " + HasIns + ", " + Bonus + ", " + Dept + ", " + Office;
        }

        /// <summary>
        /// Method to calculate taxes (number currently for reference)
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateTaxes()
        {
            return 4000; // TODO when given calculation
        }

        /// <summary>
        /// Method to calculate total earnings (number currently for reference)
        /// </summary>
        /// <returns></returns>
        public override decimal CalcTotalEarnings()
        {
            return 40000; // TODO when given calculation
        }

        //getters and setters
        public decimal Bonus
        {
            get { return bonusEarned; }
            set { bonusEarned = value; }
        }

        public string Dept
        {
            get { return department; }
            set { department = value; }
        }

        public string Office
        {
            get { return office; }
            set { office = value; }
        }

    }//end class
}//end namespace
