using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1BooksTable
{
    class CourseBook
    {
        private string course;
        private string isbn;
        private string title;

        public string Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }

        public string ISBN
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public CourseBook(string Course, string Isbn, string Title)
        {
            course = Course;
            isbn = Isbn;
            title = Title;
        }

        public override string ToString()
        {
            return Course + ", " + ISBN + ", " + Title; 
        }

    }
}
