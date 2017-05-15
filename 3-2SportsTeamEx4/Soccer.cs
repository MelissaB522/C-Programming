using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_1SportsTeamEx3;

namespace _3_2SportsTeamEx4
{
    public class Soccer : Team
    {
        //declare variables
        private string countryOfOrigin;
        private string fieldType;
        private string playerGender;

        /// <summary>
        /// Default contructor with zero arguments
        /// </summary>
        public Soccer() : base()
        {
        }

        /// <summary>
        /// Overloaded constructor that sends arguments to base class
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="coach"></param>
        /// <param name="mascot"></param>
        /// <param name="country"></param>
        /// <param name="field"></param>
        /// <param name="gender"></param>
        public Soccer(string type, string name, string coach, string mascot, string country, string field, string gender) : base(type, name, coach, mascot)
        {
            countryOfOrigin = country;
            fieldType = field;
            playerGender = gender;
        }

        //Property for the team's country of origin
        public string Country
        {
            get
            {
                return countryOfOrigin;
            }
            set
            {
                countryOfOrigin = value;
            }
        }

        //Property for the field type in which the team plays on
        public string FieldType
        {
            get
            {
                return fieldType;
            }
            set
            {
                fieldType = value;
            }
        }

        //Property for the team gender
        public string Gender
        {
            get
            {
                return playerGender;
            }
            set
            {
                playerGender = value;
            }
        }

        //Override ToString method that invokes ToString in base class and adds variables from Soccer class
        public override string ToString()
        {
            return base.ToString() + ", " + Name + ", " + Country;
        }

        /// <summary>
        /// Method to override base class to declare that number of active players on a soccer team
        /// </summary>
        /// <returns></returns>
        public override int NumberOfPlayers()
        {
            return 11;
        }

        /// <summary>
        /// Method to override base class to declare game length for a soccer game
        /// </summary>
        /// <returns></returns>
        public override string GameLength()
        {
            return "2 halves at 45 minutes each";
        }
    }//end class
}//end namespace
