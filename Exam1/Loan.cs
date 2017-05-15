using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public abstract class Loan
    {
        // declaring variables
        private int loanID;
        private DateTime dueDate;
        private decimal balance;
        private decimal paymentAmount;
        private decimal interestRate;
        private int monthTerms;

        /// <summary>
        /// Constructor with 5 arguments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="due"></param>
        /// <param name="bal"></param>
        /// <param name="intrate"></param>
        /// <param name="months"></param>
        public Loan(int id, DateTime due, decimal bal, decimal intrate, int months)
        {
            loanID = id;
            dueDate = due;
            balance = bal;
            interestRate = intrate;
            monthTerms = months;
            CalculatePayment();
        }

        /// <summary>
        /// Method to calculate due date by adding 30 days to the current date
        /// </summary>
        /// <returns></returns>
        public virtual string CalculateDueDate()
        {
            dueDate = DateTime.Today.AddDays(30);
            return dueDate.ToString();
        }

        /// <summary>
        /// Method to calculate current interest amount by multiplying the interest rate and the balance of the loan
        /// </summary>
        /// <returns></returns>
        public virtual decimal CalculateInterest()
        {
            decimal interestAmount = interestRate * balance;
            return interestAmount;
        }

        /// <summary>
        /// Method to calculate payment by taking the balance and dividing it by the months in the terms, then adding the current interest amount
        /// </summary>
        public virtual void CalculatePayment()
        {
            paymentAmount = balance / monthTerms + CalculateInterest();
        }

        // Property for the loan id
        public int LoanID
        {
            get
            {
                return loanID;
            }
            set
            {
                loanID = value;
            }
        }

        // Property for the due date
        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
            }
        }

        // Property for the balance
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        // Property for the payment amount
        public decimal PaymentAmount
        {
            get
            {
                return paymentAmount;
            }
            set
            {
                paymentAmount = value;
            }
        }
        
        // Property for the interest rate
        public decimal InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }

        // Property for the month terms
        public int MonthTerms
        {
            get
            {
                return monthTerms;
            }
            set
            {
                monthTerms = value;
            }
        }

    }//end class
}
