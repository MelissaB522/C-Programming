using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class AutoLoan : Loan
    {
        // declare variable
        private decimal downPayment;

        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="due"></param>
        /// <param name="bal"></param>
        /// <param name="payamount"></param>
        /// <param name="intrate"></param>
        /// <param name="months"></param>
        /// <param name="dnpayment"></param>
        public AutoLoan(int id, DateTime due, decimal bal, decimal intrate, int months, decimal dnpayment) : 
            base(id, due, bal, intrate, months)
        {
            downPayment = dnpayment;
        }

        // Property for down payment
        public decimal DownPayment
        {
            get
            {
                return downPayment;
            }
            set
            {
                downPayment = value;
            }
        }

        /// <summary>
        /// Overriden method to calculate payment, taking into account if there is a down payment
        /// </summary>
        public override void CalculatePayment()
        {
            base.PaymentAmount = (base.Balance - downPayment) / base.MonthTerms + CalculateInterest();            
        }
    }// end class
}
