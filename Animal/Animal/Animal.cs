using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    /// <summary>
    /// This class defines an animal object
    /// This is our base class (parent, super)
    /// </summary>
    class Animal
    {
        //define class properties
        private string name;
        //private string species;
        private char gender;
        private string color;

        //expose public variables
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //public string Species
        //{
        //    get
        //    {
        //        return species;
        //    }
        //    set
        //    {
        //        species = value;
        //    }
        //}

        //define a class constructor
        //default constructor
        public Animal()
        {
            name = "Fred";
            //species = "Cat";
            gender = 'T';
            color = "blue";
        }

        /// <summary>
        /// Override the ToString to return animal information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Hello. I am " + name + 
                //" the " + species + 
                ". I identify as " + gender + " and am a nice " + color + " color.";
        }

    }//end class
}//end namespace
