using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList anArray = new ArrayList();
            anArray.Add("Today is the first day of the " + "rest of your life!");
            anArray.Add(2);
            anArray.Add("Live it to the fullest!");
            anArray.Add(34.89);
            anArray.Add("ok");
            anArray.Add("You may not get another chance.");

            Console.WriteLine("Count of elements in array: {0}", anArray.Count);
            anArray.RemoveAt(4);
            Console.WriteLine("New Count (after removing ok): {0}", anArray.Count);
            Console.WriteLine();
            DisplayContents(anArray);
            Console.ReadKey();

        } // end main method

        private static void DisplayContents(ArrayList ar)
        {
            for (int i = 0; i < ar.Count; i++)
            {
                Console.WriteLine(ar[i]);
                // Arithmetic can be performed with numeric elements
                if (i == 1)
                {
                    Console.WriteLine((int)ar[i] * 100);
                }
            }
            Console.WriteLine();
        } // end Displaycontents method
    } // end class
}
