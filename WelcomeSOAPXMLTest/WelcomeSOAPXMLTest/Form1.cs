using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeSOAPXMLTest
{
    public partial class FrmWelcome : Form
    {
        private ServiceReference.WelcomeSOAPXMLServiceClient client;
        public FrmWelcome()
        {
            InitializeComponent();
            client = new ServiceReference.WelcomeSOAPXMLServiceClient();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(client.Welcome(txtName.Text), "Welcome");
        }
    }
}
