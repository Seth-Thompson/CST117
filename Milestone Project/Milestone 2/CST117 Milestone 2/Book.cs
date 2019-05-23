using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_Milestone_2
{
    class Book
    {
        public String firstNameAuthor { get; private set; }
        public String lastNameAuthor { get; private set; }
        public String bookTitle { get; private set; }
        public String publisher { get; private set; }
        public String isbn { get; private set; }

        public Book(String firstNameAuthor, String lastNameAuthor, String bookTitle, String publisher, String isbn)
        {
            this.firstNameAuthor = firstNameAuthor;
            this.lastNameAuthor = lastNameAuthor;
            this.bookTitle = bookTitle;
            this.publisher = publisher;
            this.isbn = isbn;
        }
    }
}
