using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Mortgage : Loan
    {
        // declare variable
        private decimal downPayment;
        private decimal mortgageValue;

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
        /// <param name="val"></param>
        public Mortgage(int id, DateTime due, decimal bal, decimal intrate, int months, decimal dnpayment, decimal val) : 
            base(id, due, bal, intrate, months)
        {
            downPayment = dnpayment;
            mortgageValue = val;
        }

        // Property for down payment on the mortgage
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

        // Property for mortgage value
        public decimal MortgageValue
        {
            get
            {
                return mortgageValue;
            }
            set
            {
                mortgageValue = value;
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
