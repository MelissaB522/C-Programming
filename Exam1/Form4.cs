using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCalcAuto_Click(object sender, EventArgs e)
        {
            PersonalLoan myPersonalLoan = new PersonalLoan(Convert.ToInt32(txtLoadID.Text), DateTime.Today.AddDays(30), Convert.ToDecimal(txtBalance.Text),
                Convert.ToDecimal(txtInterestRate.Text), Convert.ToInt32(txtMonthTerms.Text));
            txtDueDate.Text = myPersonalLoan.CalculateDueDate();
            txtInterestAmount.Text = Math.Round(myPersonalLoan.CalculateInterest(), 2).ToString();
            txtPaymentAmount.Text = Math.Round(myPersonalLoan.PaymentAmount, 2).ToString();
        }
    }
}
