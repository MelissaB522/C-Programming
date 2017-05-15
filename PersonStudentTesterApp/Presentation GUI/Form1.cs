using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNameSpace;

namespace Presentation_GUI
{
    public partial class Form1 : Form
    {
        Student aStudent;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aStudent = new Student("123456789", "Maria", "Woo", "CS", "1111");

        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            //Uses age property defined in the Person class
            aStudent.Age = 25;

            //Calls overridden ToString() in Person class
            txtbxName.Text = aStudent.ToString();

            //Calls ToString() defined in object class
            txtbxAge.Text = aStudent.Age.ToString();

            //Uses StudentID property is Student class
            txtbxSID.Text = aStudent.StudentID;

            // Calls GetSleepAmt() defined in Student class
            txtbxStudentSleep.Text = aStudent.GetSleepAmt().ToString();

            //Calls method defined in Student class that has calls to base.GetSleepAmt() in Person class
            txtbxPersonSleep.Text = aStudent.CallOverriddenGetSleepAmt().ToString();

            txtbxExercise.Text = aStudent.GetExerciseHabits();

            btnTravel.Visible = true;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            txtbxFrom.Text = aStudent.GetStartLocation();
            txtbxTo.Text = aStudent.GetDestination();
            txtbxMiles.Text = Convert.ToString(aStudent.DetermineMiles());
            txtbxFrom.Visible = true;
            txtbxTo.Visible = true;
            txtbxMiles.Visible = true;
            lblHeading.Visible = true;
            lblFrom.Visible = true;
            lblTo.Visible = true;
            lblMiles.Visible = true;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
