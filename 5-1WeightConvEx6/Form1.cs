using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_1WeightConvEx6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal numberInput = 1;

            try
            {
                lblError.Visible = false;
                txtOutput.Clear();
                // validates entry as a number
                numberInput = Convert.ToDecimal(txtInput.Text);
                // if a negative number is entered an exception is thrown
                if(numberInput < 0)
                {
                    throw new Exception();
                }

                // calls the convert method and places the returned number in the output text box
                txtOutput.Text = WeightConverter.convert(numberInput, cbFrom.Text, cbTo.Text).ToString();
            }
            catch (Exception)
            {
                // If exception is thrown, makes message visible that tells the user what they need to do to fix the problem
                lblError.Visible = true;                
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
