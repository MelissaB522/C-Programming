using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2BucketSort
{
    class BucketSort
    {
        private int[] data;
        private static Random randomNum = new Random();
        private int[,] bucket;

        // constructor
        public BucketSort(int size)
        {
            // create new array
            data = new int[size];
            // create two dimensional array for buckets
            bucket = new int[10, size];
            // fill  data array with random numbers
            for (int i = 0; i < size; i++)
            {
                data[i] = randomNum.Next(1, 100);
            }
        } // end BucketSort method

        public void Sort()
        {
            int loopCount = 0; // loopCount determines the Math.Pow
            bool keeplooping = true; 
            while (keeplooping)
            {
                keeplooping = false;
                // for loop copies from data array into buckets - distribution pass
                for (int i = 0; i < data.Length; i++)
                {
                    int row = (data[i] / (int)Math.Pow(10,loopCount)) % 10; // determines the ones, tens, hundreds, etc. place for the buckets
                    bucket[row, i] = data[i];
                    if (row > 0)
                    {
                        keeplooping = true;
                    }
                }
                // if statement breaks out of the while loop to prevent an extra pass
                if (keeplooping == false)
                {
                    break;
                }

                // for loop copies from bucket rows to data array - gathering pass
                int dataCount = 0; // dataCount variable used to keep track of the location within the array
                for (int j = 0; j < 10; j++)
                {
                    // copy from bucket columns to data array
                    for (int k = 0; k < bucket.GetLength(1); k++)
                    {
                        if(bucket[j, k] != 0)
                        {
                            data[dataCount] = bucket[j, k]; 
                            bucket[j, k] = 0; // resets buckets to 0
                            dataCount++;
                        }
                    } // end inner for
                } // end outer for
                loopCount++;
                // prints data array after each gathering pass
                PrintPass(loopCount);
            } // end while loop
        } // end Sort method

        private void PrintPass(int pass)
        {
            Console.Write("After gathering pass {0}: ", pass);

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

    } // end BucketSort class
}
