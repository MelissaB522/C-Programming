using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Jeopardy
{
    /// <summary>
    /// Class: Player
    /// Developer: Melissa Bakke
    /// Date: 12/13/16
    /// Assignment: Final Project - Jeopardy
    /// </summary>
    [Serializable]
    public class Player
    {
        // variables
        string name;
        int score;

        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        // default constructor
        public Player()
        {

        }

        // constructor
        public Player(string pname)
        {
            Name = pname;
        }

        /// <summary>
        /// Method to update a player's score
        /// </summary>
        /// <param name="amt"></param>
        public void updateScore(int amt)
        {
            Score += amt;
        }
    }
}
