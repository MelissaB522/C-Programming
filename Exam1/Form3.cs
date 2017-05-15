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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcAuto_Click(object sender, EventArgs e)
        {
            Mortgage myMortgage = new Mortgage(Convert.ToInt32(txtLoadID.Text), DateTime.Today.AddDays(30), Convert.ToDecimal(txtBalance.Text),
                Convert.ToDecimal(txtInterestRate.Text), Convert.ToInt32(txtMonthTerms.Text), Convert.ToDecimal(txtDownPayment.Text), Convert.ToDecimal(txtPropVal.Text));
            txtDueDate.Text = myMortgage.CalculateDueDate();
            txtInterestAmount.Text = Math.Round(myMortgage.CalculateInterest(), 2).ToString();
            txtPaymentAmount.Text = Math.Round(myMortgage.PaymentAmount, 2).ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
