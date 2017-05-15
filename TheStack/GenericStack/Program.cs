using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>(5);
            Stack<double> doubleStack = new Stack<double>(5);
            Stack<string> stringStack = new Stack<string>(5);

            stringStack.Push("test");
            intStack.Push(100);
            intStack.Push(200);
            doubleStack.Push(3.6);

            Console.WriteLine("Values in the 3 Stacks are: " +
                doubleStack.Pop() + ", " +
                intStack.Pop() + ", " +
                intStack.Pop() + ", " +
                stringStack.Pop());
            Console.ReadKey();

            //use the SwapData method
            string firstValue = "Programming";
            string secondValue = "C#";
            Console.WriteLine("Before swap: ");
            Console.WriteLine(firstValue + " " + secondValue);

            SwapData<string>(ref firstValue, ref secondValue);
            Console.WriteLine("After swap: ");
            Console.WriteLine(firstValue + " " + secondValue);

            Console.ReadKey();
        }

        /// <summary>
        /// This method uses a generic data type
        /// The parameters are using the same data type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public static void SwapData<T>(ref T first, ref T second)
        {
            T temp;

            temp = first;
            first = second;
            second = temp;

        }
    }
}
