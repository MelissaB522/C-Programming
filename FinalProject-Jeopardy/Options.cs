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
    /// Class: Options
    /// Developer: Melissa Bakke
    /// Date: 12/13/16
    /// Assignment: Final Project - Jeopardy
    /// </summary>
    public partial class Options : Form
    {
        GameBoard gameBoard;
        public Options(GameBoard gameBoard)
        {
            this.gameBoard = gameBoard;
            InitializeComponent();
        }

        private void cbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPlayers.SelectedIndex == 1)
            {
                lblP1.Visible = true;
                txtP1Name.Visible = true;
                lblP2.Visible = false;
                txtP2Name.Visible = false;
                lblP3.Visible = false;
                txtP3Name.Visible = false;
                button1.Visible = true;
            }
            else if (cbPlayers.SelectedIndex == 2)
            {
                lblP1.Visible = true;
                txtP1Name.Visible = true;
                lblP2.Visible = true;
                txtP2Name.Visible = true;
                lblP3.Visible = false;
                txtP3Name.Visible = false;
                button1.Visible = true;
            }
            else if (cbPlayers.SelectedIndex == 3)
            {
                lblP1.Visible = true;
                txtP1Name.Visible = true;
                lblP2.Visible = true;
                txtP2Name.Visible = true;
                lblP3.Visible = true;
                txtP3Name.Visible = true;
                button1.Visible = true;
            }
            else
            {
                lblP1.Visible = false;
                txtP1Name.Visible = false;
                lblP2.Visible = false;
                txtP2Name.Visible = false;
                lblP3.Visible = false;
                txtP3Name.Visible = false;
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameBoard.SetPlayers(cbPlayers.SelectedIndex, txtP1Name.Text, txtP2Name.Text, txtP3Name.Text);
            this.Close();
        }
    }
}
