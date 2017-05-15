using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8String
{
    class Program
    {
        static void Main(string[] args)
        {
            string sValue = "C# Programming";
            object sObj;
            string s = "C#";
            string D = "D";
            string d = "d";

            // compare sValue to s
            if (string.Compare(sValue, s) > 0)
            {
                Console.WriteLine("sValue is lexicographically greater.");
            }

            if (string.Compare(D, s) > 0)
            {
                Console.WriteLine("D is lexicographically greater.");
            }
            else
            {
                Console.WriteLine("s is lexicographically greater.");                
            }

            if (string.Compare(d, s) > 0)
            {
                Console.WriteLine("d is lexicographically greater.");
            }
            else
            {
                Console.WriteLine("s is lexicographically greater.");
            }

            // are values equal
            bool result = sValue.Equals(s);
            Console.WriteLine(result);

            // use formatting for a string
            double nu = 123.45678;
            string nn = string.Format("{0, 10:F2}", nu);
            Console.WriteLine("Formatted number: " + nn);

            Console.ReadKey();

        }
    }
}
