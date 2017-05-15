using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1LargestArray
{
    class LargestArray
    {
        private static Random randomNum = new Random();
        private int[,] largestArray;

        // LargestArray constructor
        public LargestArray (int rows, int columns)
        {
            largestArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    largestArray[i, j] = randomNum.Next(0, 100);
                }
            }
            PrintArray();
        } // end LargestArray

        // prints 2d array in matrix form
        public void PrintArray()
        {
            int rowLength = largestArray.GetLength(0);
            int columnLength = largestArray.GetLength(1);
            Console.Write("\n");
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    Console.Write("{0,3}", largestArray[i,j]);
                }
                Console.Write("\n");
            }
        } // end PrintArray

        // loops through the array looking for the largest number
        public void FindLargest(int row, int column)
        {
            int temp = 0;
            int rowIndex = 0;
            int columnIndex = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (largestArray[i,j] > temp)
                    {
                        temp = largestArray[i,j];
                        rowIndex = i;
                        columnIndex = j;
                    }
                }
            }
            Console.WriteLine("\nThe largest number in the array is {0}.\nIt is at row {1}, column {2}", temp, rowIndex+1, columnIndex+1);
        }


    } // end class
}
