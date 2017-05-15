using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialize101
{
    /* the person class creates a person object
     */
    [Serializable]
    class Person
    {
        private int age;
        private string name;
        private string employer;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Employer
        {
            get { return employer; }
            set { employer = value; }
        }

        public override string ToString()
        {
            return Name + " is " + Age + " years old";
        }

        // created new Add method and moved Insert method into it from Serializer class
        public void Add()
        {
            string serializedData = Serializer.SerializeNow(this);

            // now call the insert method of your data access class
            // to insert the serialized data
            DataAdapter.Insert(serializedData);
        }
    }
}
