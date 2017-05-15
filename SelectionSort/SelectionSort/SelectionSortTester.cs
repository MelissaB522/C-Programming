using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSortTester
    {
        static void Main(string[] args)
        {
            // create object ro perform selection sort
            SelectionSort sortArray = new SelectionSort(10);

            Console.WriteLine("Unsorted array: ");
            Console.WriteLine(sortArray); // display unsorted array

            sortArray.Sort(); // sorts array
            Console.WriteLine("Sorted array: ");
            Console.WriteLine(sortArray);
            Console.ReadKey();
        } // end Main
    }// end class
}
