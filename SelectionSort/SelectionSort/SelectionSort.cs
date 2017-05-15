using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        private int[] data; // array of integers
        private static Random generator = new Random();

        // create array of given size and fill the array with random integers
        public SelectionSort (int size)
        {
            data = new int[size];

            //fill array with random int from 10-99
            for (int i = 0; i < size; ++i)
            {
                data[i] = generator.Next(10, 99);
            }            
        }

        // sort array using selection sort
        public void Sort()
        {
            int smallest; // index of smallest element

            // loop over data.length -1 element
            for (int i = 0; i < data.Length-1; i++)
            {
                smallest = i; // first index of remaining array
                // loop to find index of smallest element
                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    } // end if                    
                } // end for 
                Swap(i, smallest); // swap smallest element into position
                PrintPass(i + 1, smallest); // output pass of algorithm
            } // end of for loop
        } // end of sort

        // helper method to swap values in two elements
        private void Swap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        } // end swap method

        private void PrintPass(int pass, int index)
        {
            Console.Write("after pass {0}: ", pass);

            // output elements through selected item
            for (int i = 0; i < index; i++)
            {
                Console.Write(data[i] + "  ");
            } // end of for

            Console.Write(data[index] + "* "); // indicate

            // finish outputting array
            for (int i = index + 1; i < data.Length; i++)
            {
                Console.Write(data[i] + "  ");
            } // end of for

            Console.WriteLine("\n");
        } // end of printpass

        // method to output values in array
        public override string ToString()
        {
            string temporary = string.Empty;

            // iterate through array
            foreach (int element in data)
            {
                temporary += element + "  ";
            }
            temporary += "\n";
            return temporary;
        } // end ToString

    } // end class
}
