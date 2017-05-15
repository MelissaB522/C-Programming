using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_1SportsTeamEx3;
using _4_2SportsTeamEx6;

namespace _3_2SportsTeamEx4
{
    public class Football : Team, IBudget
    {
        //declare variable
        private string leagueName;
        private int superBowlWins;
        private int superBowlAppearances;

        /// <summary>
        /// Default constructor with zero arguments
        /// </summary>
        public Football() : base()
        {
        }

        /// <summary>
        /// Overloaded constructor that sends arguments to base class
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="coach"></param>
        /// <param name="mascot"></param>
        /// <param name="league"></param>
        /// <param name="sbwins"></param>
        /// <param name="sbappear"></param>
        public Football(string type, string name, string coach, string mascot, string league, int sbwins, int sbappear) : base(type, name, coach, mascot)
        {
            leagueName = league;
            superBowlWins = sbwins;
            superBowlAppearances = sbappear;
        }
                
        //Property for the league that the team is in (AFC/NFC)
        public string League
        {
            get
            {
                return leagueName;
            }
            set
            {
                leagueName = value;
            }
        }

        //Property for the number of times team has won the Super Bowl
        public int SuperBowlWins
        {
            get
            {
                return superBowlWins;
            }
            set
            {
                superBowlWins = value;
            }
        }

        //Property for the number of times team has gone to the Super Bowl
        public int SuperBowlAppearances
        {
            get
            {
                return superBowlAppearances;
            }
            set
            {
                superBowlAppearances = value;
            }
        }

        //Override ToString method that invokes ToString in base class and adds variables from Football class
        public override string ToString()
        {
            return base.ToString() + ", " + Name + ", " + League;
        }

        /// <summary>
        /// Method to override base class to declare that number of active players on a football team
        /// </summary>
        /// <returns></returns>
        public override int NumberOfPlayers()
        {
            return 11;
        }

        /// <summary>
        /// Method to override base class to declare game length for a football game
        /// </summary>
        /// <returns></returns>
        public override string GameLength()
        {
            return "4 quarters at 15 minutes each";
        }

        public int CoachSalary()
        {
            return 200000;
        }

        public int EquipmentFees()
        {
            return 75000;
        }
    }//end class
}//end namespace
