using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingGarage
{
    public partial class frmTickets : Form
    {
        List<Ticket> ticketList;

        public frmTickets(List<Ticket> inputTicketList)
        {
            ticketList = inputTicketList;
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            foreach (Ticket ticket in ticketList)
            {
                string searchString = "txtbxTicket" + ticket.TicketNo;
                this.Controls.Find(searchString, false)[0].Text = ticket.ToString();
            }
        }
    }
}
