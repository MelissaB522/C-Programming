using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    /// <summary>
    /// This class will create an array of random integers are a method that searches the array sequentially
    /// </summary>
    class LinearArray
    {
        private int[] data; //array of values
        private static Random generator = new Random();

        /// <summary>
        /// Construct the class by building an array of random numbers
        /// </summary>
        /// <param name="size"></param>
        public LinearArray(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; ++i)
            {
                data[i] = generator.Next(10, 99);
            }
        }//end method

        /// <summary>
        /// Search the array for the key supplied
        /// Return key location if found, -1 if not found
        /// </summary>
        /// <param name="searchKey"></param>
        /// <returns></returns>
        public int LinearSearch (int searchKey)
        {
            //walk the array sequentially
            for (int index = 0; index < data.Length; ++index)
            {
                if (data[index] == searchKey)
                {
                    return index;
                }
            }
            return -1;
        }//end method

        /// <summary>
        /// Output all of the array entries in the temporary string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string temporary = string.Empty;

            // iterate through the array
            foreach (int element in data)
            {
                temporary += element + " ";
            }
            temporary += "\n";
            return temporary;
        } // end method
    }//end class
}
