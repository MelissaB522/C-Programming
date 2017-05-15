using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpSysPart2
{
    public partial class EmpSysForm : Form
    {
        public EmpSysForm()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // gets and stores the row index in which the chosen cell is located
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            // gets and stores the row of the row index stored in selectedRowIndex
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            // gets and stores the employee id value of the row stored in selectedRow
            int EmpID = Convert.ToInt32(selectedRow.Cells[0].Value);

            // LINQ query to display the information for the employee id stored in EmpId
            var empIDQuery =
            (from Employee in employeeDataSet.Employee
            where (Employee.EmployeeID) == EmpID
            select Employee).First();

            // if statements to determine what properties to display in message box based on employee type (class)
            if (empIDQuery.EmployeeType == "Part Time")
            {
                // LINQ qeury to display information if employee is part time
                var parttimeIDQuery =
                (from PartTimeEmployee in employeeDataSet.Employee
                where (PartTimeEmployee.EmployeeID) == EmpID
                select PartTimeEmployee).First();

                // displays selected employee's information in a message box
                MessageBox.Show("Name: " + parttimeIDQuery.FirstName + " " + empIDQuery.LastName +
                "\r\nDate Hired: " + parttimeIDQuery.DateHired +
                "\r\nSocial Security Number: " + parttimeIDQuery.SSN +
                "\r\nEmail Address: " + parttimeIDQuery.EmailAddress +
                "\r\nPhone Number: " + parttimeIDQuery.PhoneNumber +
                "\r\nTax Rate: " + parttimeIDQuery.TaxRate +
                "\r\nEmployee Type: " + parttimeIDQuery.EmployeeType +
                "\r\nHourly Rate: " + parttimeIDQuery.HourlyRate +
                "\r\nHours Worked: " + parttimeIDQuery.HoursWorked);
            }
            else if (empIDQuery.EmployeeType == "Full Time")
            {
                // LINQ qeury to display information if employee is full time
                var fulltimeIDQuery =
                (from FullTimeEmployee in employeeDataSet.Employee
                where (FullTimeEmployee.EmployeeID) == EmpID
                select FullTimeEmployee).First();

                // displays selected employee's information in a message box
                MessageBox.Show("Name: " + fulltimeIDQuery.FirstName + " " + empIDQuery.LastName +
                "\r\nDate Hired: " + fulltimeIDQuery.DateHired +
                "\r\nSocial Security Number: " + fulltimeIDQuery.SSN +
                "\r\nEmail Address: " + fulltimeIDQuery.EmailAddress +
                "\r\nPhone Number: " + fulltimeIDQuery.PhoneNumber +
                "\r\nTax Rate: " + fulltimeIDQuery.TaxRate +
                "\r\nEmployee Type: " + fulltimeIDQuery.EmployeeType +
                "\r\nSalary: " + fulltimeIDQuery.Salary +
                "\r\nVacation Days: " + fulltimeIDQuery.VacationDays +
                "\r\nSick Days: " + fulltimeIDQuery.SickDays +
                "\r\nTax Exempt: " + fulltimeIDQuery.TaxExempt +
                "\r\nHas Insurance: " + fulltimeIDQuery.HasInsurance);
            }
            else if (empIDQuery.EmployeeType == "Manager")
            {
                // LINQ qeury to display information if employee is a manager
                var managerIDQuery =
                (from Manager in employeeDataSet.Employee
                where (Manager.EmployeeID) == EmpID
                select Manager).First();

                // displays selected employee's information in a message box
                MessageBox.Show("Name: " + managerIDQuery.FirstName + " " + empIDQuery.LastName +
                "\r\nDate Hired: " + managerIDQuery.DateHired +
                "\r\nSocial Security Number: " + managerIDQuery.SSN +
                "\r\nEmail Address: " + managerIDQuery.EmailAddress +
                "\r\nPhone Number: " + managerIDQuery.PhoneNumber +
                "\r\nTax Rate: " + managerIDQuery.TaxRate +
                "\r\nEmployee Type: " + managerIDQuery.EmployeeType +
                "\r\nSalary: " + managerIDQuery.Salary +
                "\r\nVacation Days: " + managerIDQuery.VacationDays +
                "\r\nSick Days: " + managerIDQuery.SickDays +
                "\r\nTax Exempt: " + managerIDQuery.TaxExempt +
                "\r\nHas Insurance: " + managerIDQuery.HasInsurance +
                "\r\nBonus: " + managerIDQuery.Bonus +
                "\r\nDepartment: " + managerIDQuery.Department +
                "\r\nOffice: " + managerIDQuery.Office);
            }
        } // end display

        private void EmpSysForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mb0242181DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.mb0242181DataSet.Employee);
            // This line of code loads data into the 'employeeDataSet.Employee' data grid view
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if else statements to determine and display each type of employee
            if (cmbbxType.Text == "Full Time")
            {
                // LINQ Query to display only full time employees
                var fulltimeQuery =
                from Employee in employeeDataSet.Employee
                where (Employee.EmployeeType) == "Full Time"
                select Employee;
                dataGridView1.DataSource = fulltimeQuery.AsDataView();
            }
            else if (cmbbxType.Text == "Part Time")
            {
                // LINQ Query to display only part time employees
                var parttimeQuery =
                from Employee in employeeDataSet.Employee
                where (Employee.EmployeeType) == "Part Time"
                select Employee;
                dataGridView1.DataSource = parttimeQuery.AsDataView();
            }
            else if (cmbbxType.Text == "Manager")
            {
                // LINQ Query to display only managers
                var managerQuery =
                from Employee in employeeDataSet.Employee
                where (Employee.EmployeeType) == "Manager"
                select Employee;
                dataGridView1.DataSource = managerQuery.AsDataView();
            }
            else if (cmbbxType.Text == "All")
            {
                // LINQ Query to display all employees
                var fillQuery =
                from Employee in employeeDataSet.Employee
                select Employee;
                dataGridView1.DataSource = fillQuery.AsDataView();
            }
        } // end drop box options

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // prompt box to ensure you want to delete the row
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this row?", "STOP!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DialogResult dialog2 = MessageBox.Show("Are you REALLY sure you want to delete this row?", "WAIT!!", MessageBoxButtons.YesNo);
                if (dialog2 == DialogResult.Yes)
                {
                    // gets and stores the row index in which the chosen cell is located
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    // delete row
                    dataGridView1.Rows.RemoveAt(selectedRowIndex);

                }
            }
        } // end remove
    } // end partial class
}
