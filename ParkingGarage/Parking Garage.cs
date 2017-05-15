using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ParkingGarage
{
    public partial class Form1 : Form
    {
        int ticketCounter = 0;
        List<Ticket> ticketList = new List<Ticket>();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtbxCharge.Visible = false; // turns off charge messages
            lblCharge.Visible = false;
            // if over 25 the garage is full, turns on full message and disables enter button
            if (ticketCounter >= 25)
            {
                lblFull.Visible = true;
                btnEnter.Enabled = false;
            }
            // if not full a new ticket is made and added to a list
            else
            {
                ticketCounter++;
                Ticket newTicket = new Ticket(ticketCounter, DateTime.Now);
                ticketList.Add(newTicket);
                txtbxTicketIn.Text = ticketCounter.ToString();
            }            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            lblFull.Visible = false; // turns off full message
            // try catch to make sure a ticket number is entered
            try
            {
                int ticketnum = Convert.ToInt32(txtbxTicketOut.Text);
                lblEnterTicket.Visible = false;
                // foreach loop cycles through the tickets until it finds the one that was entered, adds the timeOut property and calculates charge for that ticket
                foreach (Ticket ticket in ticketList)
                {
                    if (ticket.TicketNo == ticketnum)
                    {
                        ticket.TimeOut = DateTime.Now;
                        txtbxCharge.Text = "$" + ticket.CalculateCharge().ToString();
                        txtbxCharge.Visible = true;
                        lblCharge.Visible = true;
                    } // end if
                } // end foreach
            }
            catch (Exception)
            {
                // if ticket number is not entered a message appears telling user to enter the ticket number
                lblEnterTicket.Visible = true; 
            }            
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            // sends the ticket list to the new form for displaying the tickets and opens Tickets form
            frmTickets frmTickets = new frmTickets(ticketList);
            frmTickets.Show();
        }

        private void btnSaveTickets_Click(object sender, EventArgs e)
        {
            // save tickets to xml file - from dot net perls
            using (XmlWriter writer = XmlWriter.Create("tickets.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Tickets");

                foreach (Ticket ticket in ticketList)
                {
                    writer.WriteStartElement("Ticket");
                    writer.WriteElementString("TicketNumber", ticket.TicketNo.ToString());
                    writer.WriteElementString("TimeIn", ticket.TimeIn.ToString("hh:mm tt"));
                    // if the ticket hasn't been "exited" time out and charge are NA
                    if (ticket.TimeOut == DateTime.MinValue)
                    {
                        writer.WriteElementString("TimeOut", "NA");
                        writer.WriteElementString("Charge", "NA");
                    }
                    else
                    {
                        writer.WriteElementString("TimeOut", ticket.TimeOut.ToString("hh:mm tt"));
                        writer.WriteElementString("Charge", ticket.CalculateCharge().ToString());
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
