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
    /// Class: Splash
    /// Developer: Melissa Bakke
    /// Date: 12/13/16
    /// Assignment: Final Project - Jeopardy
    /// </summary>
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                GameBoard gameBoard = new GameBoard();
                gameBoard.Show();
                this.Hide();
            }
        }
    }
}
