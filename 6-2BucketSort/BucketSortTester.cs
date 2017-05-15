using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2BucketSort
{
    class BucketSortTester
    {
        static void Main(string[] args)
        {
            BucketSort sortArray = new BucketSort(50);
            Console.WriteLine("Unsorted Array: ");
            Console.WriteLine(sortArray);
            sortArray.Sort();
            Console.WriteLine("Sorted Array: ");
            Console.WriteLine(sortArray);
            Console.ReadKey();
        } // end Main method
    } // end class
}
