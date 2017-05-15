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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcAuto_Click(object sender, EventArgs e)
        {
            AutoLoan myAutoLoan = new AutoLoan(Convert.ToInt32(txtLoadID.Text), DateTime.Today.AddDays(30), Convert.ToDecimal(txtBalance.Text),
                Convert.ToDecimal(txtInterestRate.Text), Convert.ToInt32(txtMonthTerms.Text), Convert.ToDecimal(txtDownPayment.Text));
            txtDueDate.Text = myAutoLoan.CalculateDueDate();
            txtInterestAmount.Text = Math.Round(myAutoLoan.CalculateInterest(),2).ToString();            
            txtPaymentAmount.Text = Math.Round(myAutoLoan.PaymentAmount,2).ToString();
        }

        private void txtInterestAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
