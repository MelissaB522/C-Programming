using PetalsAroundTheRose.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetalsAroundTheRose
{
    class Dice
    {
        
        Image[] dicePics = new Image[] {Resources._0_border, Resources._1_border, Resources._2_border, Resources._3_border, Resources._4_border, Resources._5_border, Resources._6_border};

        /// <summary>
        /// Gets or sets the dice image
        /// </summary>
        public Image diceImage { get; set; }

        /// <summary>
        /// Gets or sets the dice values
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Dice()
        {
            Value = 0;
            diceImage = dicePics[Value];
        }

        /// <summary>
        /// Method to roll dice and set values and pictures
        /// </summary>
        /// <param name="randNum"></param>
        public void Roll(Random randNum)
        {
            Value = randNum.Next(1, 7);
            diceImage = dicePics[Value];
        }

        /// <summary>
        /// Method to set game value
        /// </summary>
        /// <returns></returns>
        public int petalValue()
        {
            if (Value == 3)
            {
                return 2;
            }
            else if (Value == 5)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }
    }//end class
}
