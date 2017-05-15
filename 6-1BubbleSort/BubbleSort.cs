using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort // Bubble sort is an O(n2) algorithm because every element is compared to every element.
    {
        private int[] data;
        private static Random randomNum = new Random();

        public BubbleSort(int size)
        {
            // create new array
            data = new int[size];

            // fill array with random numbers
            for (int i = 0; i < size; i++)
            {
                data[i] = randomNum.Next(10, 99);
            }            
        } // end BubbleSort method

        public void Sort()
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int index = 0; index < data.Length - 1; index++)
                {
                    if (data[index] > data[index + 1]) // compares 2 adjacent indexes
                    {
                        Swap(index, index + 1); 
                    }
                }
                // outputs all elements after each inner loop
                PrintPass(i + 1);
            }
        } // end Sort method

        // swaps the largest number with the number in the next index
        private void Swap(int first, int next)
        {
            int temp = data[first];
            data[first] = data[next];
            data[next] = temp;
        } // end Swap method

        private void PrintPass(int pass)
        {
            Console.Write("After pass {0}: ", pass);

            // outputs all elements
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + "  ");
            }
            Console.WriteLine("\n");
        } // end PrintPass method

        public override string ToString()
        {
            string temp = string.Empty;

            foreach (int element in data)
            {
                temp += element + "  ";
            }
            temp += "\n";
            return temp;
        } // end ToString
    } // end BubbleSort class
} // end namespace
