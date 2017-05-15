using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_Jeopardy
{
    /// <summary>
    /// Class: Results
    /// Developer: Melissa Bakke
    /// Date: 12/13/16
    /// Assignment: Final Project - Jeopardy
    /// </summary>
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddResult(Player[] players, int GameID)
        {
            string resultstring = "";

            resultstring += "GAME " + GameID + " ";
            resultstring += " Player 1: " + players[0].Name + " - " + players[0].Score + "   ";
            if (players[1].Name != "")
            {
            resultstring += " Player 2: " + players[1].Name + " - " + players[1].Score + "   ";            
            }
            if (players[2].Name != "")
            {
                resultstring += " Player 3: " + players[2].Name + " - " + players[2].Score + "   ";
            }
            lstbxResults.Items.Add(resultstring);
        }
    }
}
