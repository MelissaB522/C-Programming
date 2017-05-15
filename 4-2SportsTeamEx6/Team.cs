using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1SportsTeamEx3
{
    public abstract class Team
    {
        //declare variables
        private string sportType;
        private string teamName;
        private string coachName;
        private string teamMascot;

        /// <summary>
        /// Constructor with zero arguments
        /// </summary>
        public Team()
        {
        }

        /// <summary>
        /// Constructor with 4 arguments
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="coach"></param>
        /// <param name="mascot"></param>
        public Team(string type, string name, string coach, string mascot)
        {
            sportType = type;
            teamName = name;
            coachName = coach;
            teamMascot = mascot;
        }

        //Property for the type of sport
        public string Type
        {
            get
            {
                return sportType;
            }
            set
            {
                sportType = value;
            }
        }

        //Property for the name of the team
        public string Name
        {
            get
            {
                return teamName;
            }
            set
            {
                teamName = value;
            }
        }

        //Property for the name of the coach
        public string Coach
        {
            get
            {
                return coachName;
            }
            set
            {
                coachName = value;
            }
        }
        
        //Property for the mascot of the team
        public string Mascot
        {
            get
            {
                return teamName;
            }
            set
            {
                teamMascot = value;
            }
        }

        public override string ToString()
        {
            return sportType + ", " + coachName;
        }

        /// <summary>
        /// Method the returns number of active players
        /// </summary>
        /// <returns></returns>
        public virtual int NumberOfPlayers()
        {
            return 0;
        }

        /// <summary>
        /// Method the returns the length of the game
        /// </summary>
        /// <returns></returns>
        public virtual string GameLength()
        {
            return "1 whole game";
        }

    }//end class
}//end namespace
