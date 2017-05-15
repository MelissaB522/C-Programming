using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class LinearArrayTester
    {
        static void Main(string[] args)
        {
            int searchInt; // search key
            int position; // location of search key

            // create array and output it
            LinearArray searchArray = new LinearArray(10);
            Console.WriteLine(searchArray);

            // input first int from user
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());

            while (searchInt != -1)
            {
                position = searchArray.LinearSearch(searchInt);
                if (position != -1)
                {
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);
                } // end if
                else
                {
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                }// end else
                // input next integer from user
                Console.Write("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());

            } // end while
        }//end Main method
    }//end class
}
