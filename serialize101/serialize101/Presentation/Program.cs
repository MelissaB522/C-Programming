using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialize101
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Age = 43;
            myPerson.Name = "Mike Johnson";
            myPerson.Employer = "OTC";

            //changed from SerializeNow method to Add method
            myPerson.Add();

            Console.Write(myPerson.ToString());
            Console.ReadKey();
        }
    }
}
