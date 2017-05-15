using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpSysPart1
{
    public partial class formEmpSys : Form
    {
        public formEmpSys()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) // TODO only employee class is implemented right not, must add other classes
        {
            if (txtEmail.Text.Contains('@') && txtEmail.Text.Contains('.')) //validation
            {
                Employee myEmployee = new Employee();
                myEmployee.Email = txtEmail.Text;
                myEmployee.FirstName = txtFirstName.Text;
                myEmployee.LastName = txtLastName.Text;
                myEmployee.DateHired = DTDateHired.Value.Date;
                myEmployee.Social = txtSocial.Text;
                myEmployee.Email = txtEmail.Text;
                myEmployee.Phone = txtPhone.Text;
                myEmployee.TaxRate = Convert.ToDecimal(txtTaxRate.Text);
                
                MessageBox.Show(myEmployee.ToString());

                txtTaxes.Text = Convert.ToString(myEmployee.CalculateTaxes());
                txtTotalEarn.Text = Convert.ToString(myEmployee.CalcTotalEarnings());
            }
            else
            {
                MessageBox.Show("Email address must contain . and @. (name@email.com)");                
            }            
        }

        //updating form based on employee type chosen
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cbxEmployeeType.SelectedItem.ToString() == "Full Time") // TODO implement full time class in program, make unrelated controls invisible
            {
                txtSalary.Visible = true;
                lblSalary.Visible = true;
                txtVacation.Visible = true;
                lblVacation.Visible = true;
                txtSick.Visible = true;
                lblSick.Visible = true;
                CkTaxExempt.Visible = true;
                lblTaxExempt.Visible = true;
                ckbxInsurance.Visible = true;
                lblHasInsurance.Visible = true;
            }
            else if (cbxEmployeeType.SelectedItem.ToString() == "Manager") // TODO implement manager class in program, make unrelated controls invisible
            {
                txtBonus.Visible = true;
                lblBonus.Visible = true;
                txtDept.Visible = true;
                lblDept.Visible = true;
                txtOffice.Visible = true;
                lblOffice.Visible = true;
            }
            else if (cbxEmployeeType.SelectedItem.ToString() == "Part Time") // TODO implement part time class in program, make unrelated controls invisible
            {
                TextBox txtHourlyRate = new TextBox();
                txtHourlyRate.Location = new Point(txtSalary.Location.X, txtSalary.Location.Y);
                txtHourlyRate.Size = txtSalary.Size;
                this.Controls.Add(txtHourlyRate);
                Label lblHourlyRate = new Label();
                lblHourlyRate.Location = new Point(lblSalary.Location.X-25, lblSalary.Location.Y);
                lblHourlyRate.Text = "Hourly Rate";
                lblHourlyRate.Size = lblTaxExempt.Size;
                this.Controls.Add(lblHourlyRate);
                TextBox txtHoursWorked = new TextBox();
                txtHoursWorked.Location = new Point(txtVacation.Location.X, txtVacation.Location.Y);
                txtHoursWorked.Size = txtVacation.Size;
                this.Controls.Add(txtHoursWorked);
                Label lblHoursWorked = new Label();
                lblHoursWorked.Location = new Point(lblVacation.Location.X+15, lblVacation.Location.Y);
                lblHoursWorked.Text = "Department";
                lblHoursWorked.Size = lblTaxExempt.Size;
                this.Controls.Add(lblHoursWorked);
            }
        }//end combobox selection
    }//end class
}//end namespace
