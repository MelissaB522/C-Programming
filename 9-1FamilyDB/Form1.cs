using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_1FamilyDB
{
    public partial class FamilyDB : Form
    {
        public FamilyDB()
        {
            InitializeComponent();
        }

        private void FamilyDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'familyDataSet.Family' table. You can move, or remove it, as needed.
            this.familyTableAdapter.Fill(this.familyDataSet.Family);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.familyTableAdapter.FillBy(this.familyDataSet.Family);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.familyTableAdapter.Fill(this.familyDataSet.Family);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
