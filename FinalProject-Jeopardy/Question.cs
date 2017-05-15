using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Jeopardy
{
    /// <summary>
    /// Class: Question
    /// Developer: Melissa Bakke
    /// Date: 12/13/16
    /// Assignment: Final Project - Jeopardy
    /// </summary>
    [Serializable]
    public class Question
    {
        // variables
        int points;
        string answer;
        string category;
        string question;

        // constructor
        public Question()
        {

        }

        // properties
        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Ques
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
            }
        }

        public override string ToString()
        {
            return "Points: " + Points + " Answer: " + Answer + " Category: " + Category + " Question: " + Ques; 
        }
    }
}
