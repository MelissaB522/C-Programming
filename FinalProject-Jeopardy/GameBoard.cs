using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.Data.SqlClient; // sql directive

namespace FinalProject_Jeopardy
{
    /// <summary>
    /// Class: GameBoard
    /// Developer: Melissa Bakke
    /// Date: 12/13/16
    /// Assignment: Final Project - Jeopardy
    /// </summary>
    public partial class GameBoard : Form
    {
        // sql stuff
        #region 
        private SqlConnection dbConn;     // object to hold our connection
        private string sConnection;         // connection string

        private SqlCommand dbCmd;         // command object
        private string sql;                 // command to run

        private SqlDataReader dbReader;   // object for reader
        #endregion 

        // 2d array of questions
        Question[,] gameBoardQuestions = new Question[5, 5];
        // array of players
        Player[] players = new Player[3];
        int questionCounter = 0;
        int numberOfPlayers = 0;

        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            // rules dialog box
            DialogResult dialogResult = MessageBox.Show("1. Click the options button to select the number of players and enter their names, then click play." +
                "\n2. Click the game buttons to get each question." + 
                "\n3. On the question/answer form choose the player that is answering, enter the answer in the textbox in the form of a question, then click enter." + 
                "\n4. If the answer was correct, click yes. If not, click no. Contine until all question have been selected." + 
                "\n\nYou can start a new game at any time by clicking the New Game button. \nYou can see past games by clicking the History button.", "Rules", MessageBoxButtons.OK);
            
            // create players and add them to array
            Player player1 = new Player();
            players[0] = player1;
            Player player2 = new Player();
            players[1] = player2;
            Player player3 = new Player();
            players[2] = player3;

            // category counter determines columns in 2d array
            int categoryCounter = 0;
            XmlTextReader reader = new XmlTextReader("Jeopardy.xml");
            while (reader.Read())
            {
                if (reader.IsStartElement()) // opening tag in xml
                {
                    if (reader.Name == "category")
                    {
                        // start new category
                        string categoryName = reader.GetAttribute(0);
                        
                        while (reader.Read())
                        {
                            // at closing tag end category
                            if (!reader.IsStartElement() && reader.Name == "category") // closing category tag in xml
                            {
                                // ended category, exited loop
                                break;
                            }
                            string value = "";
                            if(reader.Value != "")
                            {
                                value = reader.Value;
                            }

                            if (reader.IsStartElement())
                            {
                                int row = 0;
                                // set row for each question, determines rows of 2d array
                                if (reader.Name == "first")
                                {
                                    row = 0;
                                }
                                else if (reader.Name == "second")
                                {
                                    row = 1;
                                }
                                else if (reader.Name == "third")
                                {
                                    row = 2;
                                }
                                else if (reader.Name == "fourth")
                                {
                                    row = 3;
                                }
                                else if (reader.Name == "fifth")
                                {
                                    row = 4;
                                }
                                // new instance of a Question
                                Question question = new Question();
                                question.Category = categoryName;
                                question.Points = Convert.ToInt32(reader.GetAttribute(0)); // gets points value
                                question.Answer = reader.GetAttribute(1); // gets answer string
                                question.Ques = reader.ReadString(); // gets question string
                                // add new question to question 2d array
                                gameBoardQuestions[row, categoryCounter] = question;
                            }

                        } // end while
                        // increment category
                        categoryCounter++;
                    }
                } // end while
            }
            txtCat1.Text = gameBoardQuestions[0, 0].Category;
            txtCat2.Text = gameBoardQuestions[0, 1].Category;
            txtCat3.Text = gameBoardQuestions[0, 2].Category;
            txtCat4.Text = gameBoardQuestions[0, 3].Category;
            txtCat5.Text = gameBoardQuestions[0, 4].Category;
        } // end GameBoard Load

        // this method is triggered by ALL game buttons, set in click event in properties
        private void btnCat1100_Click(object sender, EventArgs e)
        {
            btnOptions.Visible = false;
            Question selectedQuestion;
            // determines actual button clicked 
            Button clickedButton = (Button) sender;
            int row = 0;
            int column = 0;
            // sets rows and columns of game board with 2d array
            if(clickedButton.AccessibleDescription == "Category1")
            {
                column = 0;
            }
            else if (clickedButton.AccessibleDescription == "Category2")
            {
                column = 1;
            }
            else if (clickedButton.AccessibleDescription == "Category3")
            {
                column = 2;
            }
            else if (clickedButton.AccessibleDescription == "Category4")
            {
                column = 3;
            }
            else if (clickedButton.AccessibleDescription == "Category5")
            {
                column = 4;
            }
            if (clickedButton.AccessibleName == "First")
            {
                row = 0;
            }
            else if (clickedButton.AccessibleName == "Second")
            {
                row = 1;
            }
            else if (clickedButton.AccessibleName == "Third")
            {
                row = 2;
            }
            else if (clickedButton.AccessibleName == "Fourth")
            {
                row = 3;
            }
            else if (clickedButton.AccessibleName == "Fifth")
            {
                row = 4;
            }
            selectedQuestion = gameBoardQuestions[row, column];
            // disable clicked button
            clickedButton.Text = " ";
            clickedButton.Enabled = false;
            // open a and q form
            AandQ answerform = new AandQ(selectedQuestion, this, numberOfPlayers, players);
            answerform.Show();
        } // end btn click

        public void updatePlayerScore(int playerIndex, int scoreChange)
        {
            Player temp = players[playerIndex];
            temp.Score += scoreChange;
            // update player score on game board
            if (playerIndex == 0)
            {
                txtPlayer1.Text = "$" + temp.Score.ToString();
            }
            else if (playerIndex == 1)
            {
                txtPlayer2.Text = "$" + temp.Score.ToString();
            }
            else if (playerIndex == 2)
            {
                txtPlayer3.Text = "$" + temp.Score.ToString();
            }
            // increment question counter
            questionCounter++;

            // if all buttons have been clicked, game is over, results sent to database, game restarted
            if (questionCounter == 25)
            {
                DialogResult dialogResult = MessageBox.Show("Game over. Results saved.", "Game Over", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    //sends results to database
                    SaveGameResults();
                    // starts a new game
                    Application.Exit();
                    Application.Restart();
                }
            }
        }
        // method to send results to database
        private void SaveGameResults()
        {
            // connection string
            sConnection =
                    "Data Source=stusql.otc.edu;" +
                    "Initial Catalog=mb0242181;" +
                    "Integrated Security=True;";

            // create our connection
            dbConn = new SqlConnection(sConnection);
            dbConn.Open();
            string serializedData;
            serializedData = Serializer.SerializeNow(players);

            // build the command to run
            sql = "INSERT INTO JeopardyResults(Data)VALUES(@serializedData);";

            // construct the command object
            dbCmd = new SqlCommand();
            dbCmd.CommandText = sql;

            // add data values
            dbCmd.Parameters.AddWithValue("@serializedData", serializedData);

            // tie the OldDbCommand object to the OleDbConnection object
            dbCmd.Connection = dbConn;

            // execute insert statement
            dbCmd.ExecuteNonQuery();

            // close the connection
            dbConn.Close();
        }

        //starts new game
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // open options form
            Options optionsForm = new Options(this);
            optionsForm.Show();
        }

        // set players method
        public void SetPlayers(int numberOfPlayers, string P1Name, string P2Name, string P3Name)
        {
            this.numberOfPlayers = numberOfPlayers;
            lblPlayer1.Text = P1Name;
            players[0].Name = P1Name;
            lblPlayer2.Text = P2Name;
            players[1].Name = P2Name;
            lblPlayer3.Text = P3Name;
            players[2].Name = P3Name;
            if (numberOfPlayers == 1)
            {
                lblPlayer2.Visible = false;
                txtPlayer2.Visible = false;
                lblPlayer3.Visible = false;
                txtPlayer3.Visible = false;
            }
            else if (numberOfPlayers == 2)
            {
                lblPlayer3.Visible = false;
                txtPlayer3.Visible = false;
            }
        }

        // load results from database
        private void btnHistory_Click(object sender, EventArgs e)
        {
            Results results = new Results();
            try
            {
                sConnection =
                    "Data Source=stusql.otc.edu;" +
                    "Initial Catalog=mb0242181;" +
                    "Integrated Security=True;";

                // create our connection
                dbConn = new SqlConnection(sConnection);
                dbConn.Open();

                // build the command to run
                sql = "SELECT * FROM JeopardyResults;";

                // construct the command object
                dbCmd = new SqlCommand();
                dbCmd.CommandText = sql;

                // tie the SQLCommand object to the SQLConnection object
                dbCmd.Connection = dbConn;

                // create a dbReader object
                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    Player[] players = Serializer.DeSerializeNow(dbReader["Data"].ToString());
                    results.AddResult(players, Convert.ToInt32(dbReader["GameID"]));
                }

                // close the reader
                dbReader.Close();
                // close the connection
                dbConn.Close();
            } // end of try
            catch (System.Exception exc)
            {
                this.lblMessage.Text = exc.Message;
            } // end of catch
            // open Results form
            results.Show();
        }
    } // end form class
}
