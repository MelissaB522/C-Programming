using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7_1LargestArray;

namespace _7_1LargestArray
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows you want: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns you want: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            LargestArray largestArray = new LargestArray(rows, columns);
            largestArray.FindLargest(rows, columns);
            Console.ReadKey();
        }
    }
}
