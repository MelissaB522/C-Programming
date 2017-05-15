using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1BooksTable
{
    class Book
    {
        private string isbn;
        private string title;
        private string copyright;
        private string author;
        private string publisher;
        private int page;

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

        public Book(string Isbn, string Title)
        {
            isbn = Isbn;
            title = Title;
        }
    }
}
