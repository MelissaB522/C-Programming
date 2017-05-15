using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetalsAroundTheRose
{
    class Game
    {
        Random randNum = new Random();
        public Dice die1 = new Dice();
        public Dice die2 = new Dice();
        public Dice die3 = new Dice();
        public Dice die4 = new Dice();
        public Dice die5 = new Dice();
        public int petalValue = 0;

        public List<Dice> rolledDice = new List<Dice>();
        
        /// <summary>
        /// method to add dice to list
        /// </summary>
        public Game()
        {
            rolledDice.Add(die1);
            rolledDice.Add(die2);
            rolledDice.Add(die3);
            rolledDice.Add(die4);
            rolledDice.Add(die5);
        }

        /// <summary>
        /// Method to set value for each die
        /// </summary>
        public void rollDice()
        {
            petalValue = 0;
            foreach (Dice die in rolledDice)
            {
                die.Roll(randNum);
                petalValue += die.petalValue();
            }            
        }
    }//end class
}
