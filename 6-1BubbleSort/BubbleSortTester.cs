using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSortTester // Bubble sort is an O(n2) algorithm because every element is compared to every element.
    {
        static void Main(string[] args)
        {
            // create object to perform Bubble Sort
            BubbleSort sortArray = new BubbleSort(100);

            Console.WriteLine("Unsorted array: ");
            Console.WriteLine(sortArray); // display unsorted array

            sortArray.Sort(); // sort array
            Console.WriteLine("Sorted array: ");
            Console.WriteLine(sortArray);
            Console.ReadKey();
        } // end main method
    } // end BubbleSortTester class
} // end namespace
