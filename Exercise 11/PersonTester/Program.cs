using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_11;

namespace PersonTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student("123456789", "Maria", "Woo", "CS", "1111");
            Console.WriteLine(aStudent.ToString());

            Console.ReadKey();
        }
    }
}
