using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class PersonalLoan : Loan
    {
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="due"></param>
        /// <param name="bal"></param>
        /// <param name="payamount"></param>
        /// <param name="intrate"></param>
        /// <param name="months"></param>
        public PersonalLoan(int id, DateTime due, decimal bal, decimal intrate, int months) : 
            base(id, due, bal, intrate, months)
        {
        }

        /// <summary>
        /// Overridden calculate payment method6
        /// </summary>
        public override void CalculatePayment()
        {
            base.CalculatePayment();
        }
    }// end class
}
