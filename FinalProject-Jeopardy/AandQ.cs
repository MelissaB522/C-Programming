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
    /// Class: AandQ
    /// Developer: Melissa Bakke
    /// Date: 12/13/16
    /// Assignment: Final Project - Jeopardy
    /// </summary>
    public partial class AandQ : Form
    {
        Question selectedQuestion;
        GameBoard gameBoard;
        int playerIndex = 0;
        int numberOfPlayers = 0;
        // array of players
        Player[] players = new Player[3];

        public AandQ(Question selectedQuestion, GameBoard gameBoard, int numberOfPlayers, Player[] players)
        {
            this.selectedQuestion = selectedQuestion;
            this.gameBoard = gameBoard;
            this.numberOfPlayers = numberOfPlayers;
            this.players = players;
            InitializeComponent();
        }


        private void AandQ_Load(object sender, EventArgs e)
        {
            lblValue.Text = "$" + selectedQuestion.Points.ToString();
            lblCategory.Text = selectedQuestion.Category;
            txtQuestion.Text = selectedQuestion.Ques;
            btnPlayer1.Text = players[0].Name;
            btnPlayer2.Text = players[1].Name;
            btnPlayer3.Text = players[2].Name;
            if (numberOfPlayers == 1)
            {
                btnPlayer2.Visible = false;
                btnPlayer3.Visible = false;
            }
            else if (numberOfPlayers == 2)
            {
                btnPlayer3.Visible = false;
            }
        }

        private void btnEnterAnswer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Player's answer: " + txtPlayerAnswer.Text + 
                "\nCorrect Answer: " + selectedQuestion.Answer + "\n\nWas the player correct?", "Answer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                gameBoard.updatePlayerScore(playerIndex, selectedQuestion.Points);
            }
            else if (dialogResult == DialogResult.No)
            {
                gameBoard.updatePlayerScore(playerIndex, selectedQuestion.Points*-1);
            }
            this.Close();
        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            playerIndex = 0;
            ShowStuff();
            
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            playerIndex = 1;
            ShowStuff();
        }

        private void btnPlayer3_Click(object sender, EventArgs e)
        {
            playerIndex = 2;
            ShowStuff();
        }

        // turns stuff on after a player is chosen
        private void ShowStuff()
        {
            lblPrompt.Visible = true;
            txtPlayerAnswer.Visible = true;
            btnEnterAnswer.Visible = true;
        }
    }
}
