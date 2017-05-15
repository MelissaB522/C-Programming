using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    /// <summary>
    /// The Dog class is derived from the Animal class
    /// </summary>
    class Dog : Animal
    {
        private string breed;

        public string Breed
        {
            get
            {
                return breed;
            }

            set
            {
                breed = value;
            }
        }

        public override string ToString()
        {
            return "Hello. I am a dog named " +
                base.Name + ". " +
                "My breed is " + breed; 
        }
    }//end class
}//end namespace
