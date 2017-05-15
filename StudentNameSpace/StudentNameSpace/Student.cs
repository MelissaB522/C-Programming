using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNameSpace;
using ITravelerInterfaceNamespace;

namespace StudentNameSpace
{
    /// <summary>
    /// This class creates a Student object
    /// The Student inherits from the Person class
    /// </summary>
    public class Student : Person, ITraveler 
    {
        private string major;
        private string studentId;

        /// <summary>
        /// This is a no argument constructor
        /// </summary>
        public Student()
            : base() // no arguments sent to base class
        {

        }
        /// <summary>
        /// This constructor builds a complete student object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="maj"></param>
        /// <param name="sId"></param>
        public Student(string id,
                       string fname,
                       string lname,
                       string maj,
                       string sId)
            : base(id, lname, fname)
        {
            major = maj;
            studentId = sId;
        }
        /// <summary>
        /// StudentID is read only; there is no setter
        /// </summary>
        public string StudentID
        {
            get
            {
                return studentId;
            }
        }
        /// <summary>
        /// Major is a read/write property
        /// </summary>
        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// This method will return a sleep amount of 6
        /// </summary>
        /// <returns></returns>
        public override int GetSleepAmt()
        {
            return 6;
        }
        /// <summary>
        /// This method calls the base class GetSleepAmt
        /// method.
        /// </summary>
        /// <returns></returns>
        public int CallOverriddenGetSleepAmt()
        {
            return base.GetSleepAmt();
        }

        /// <summary>
        /// This method overrides the abstract method declared in the parent class
        /// </summary>
        /// <returns></returns>
        public override string GetExerciseHabits()
        {
            return "Exercises Daily";
        }

        /// <summary>
        /// Implement the GetDestination method required by the interface
        /// </summary>
        /// <returns></returns>
        public string GetDestination()
        {
            return "Home";
        }

        /// <summary>
        /// Implement the GetStartLocation method required by the interface
        /// </summary>
        /// <returns></returns>
        public string GetStartLocation()
        {
            return "School";
        }

        /// <summary>
        /// Implement the DetermineMiles method required by the interface
        /// </summary>
        /// <returns></returns>
        public double DetermineMiles()
        {
            return 75.0;
        }
    }//end class
}//end namespace
