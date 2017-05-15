using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetalsAroundTheRose
{
    public partial class Form1 : Form
    {
        //declare wariables
        Game theGame = new Game();
        int totalRolls = 0;
        int correctGuesses = 0;
        int currentRun = 0;
        int bestRun = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a die with its image to each picture box
        /// </summary>
        public void setPics()
        {
            pictureBox1.Image = theGame.die1.diceImage;
            pictureBox2.Image = theGame.die2.diceImage;
            pictureBox3.Image = theGame.die3.diceImage;
            pictureBox4.Image = theGame.die4.diceImage;
            pictureBox5.Image = theGame.die5.diceImage;
        }

        /// <summary>
        /// Compare user guess to actual value to determine if it is correct or not
        /// </summary>
        public void compareGuess()
        {
            int playerGuess = Convert.ToInt32(TBPlayerGuess.Text);
            if (playerGuess == theGame.petalValue)
            {
                LblInput.Visible = true;
                LblInput.BackColor = Color.Green;
                LblInput.Text = "You are correct!";
                BtnRoll.Visible = true;
                correctGuesses += 1;
                currentRun += 1;
                if (currentRun > bestRun)
                {
                    bestRun = currentRun;
                }
            }
            else
            {
                LblInput.Visible = true;
                LblInput.BackColor = Color.Red;
                LblInput.Text = "Wrong answer...";
                BtnRoll.Visible = true;
                currentRun = 0;
            }
        }

        //actions that happen when Roll button is clicked
        private void BtnRoll_Click(object sender, EventArgs e)
        {
            LblInput.Visible = false;
            theGame.rollDice();
            setPics();
            BtnEnter.Visible = true;
            TBPlayerGuess.Text = "";
            BtnRoll.Visible = false;

        }

        //actions that happen when Enter button is clicked
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            compareGuess();
            totalRolls += 1;
            TBTotalRolls.Text = totalRolls.ToString();
            BtnEnter.Visible = false;
            TBcorrectguesses.Text = correctGuesses.ToString();
            TBincorrectguesses.Text = (totalRolls - correctGuesses).ToString();
            TBCurrentrun.Text = currentRun.ToString();
            TBBestrun.Text = bestRun.ToString();
            BtnRoll.Enabled = true;
        }
    }
}
