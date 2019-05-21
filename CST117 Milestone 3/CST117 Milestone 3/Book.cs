using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_Milestone_3
{
    class Book
    {
        public String firstNameAuthor { get; private set; }
        public String lastNameAuthor { get; private set; }
        public String bookTitle { get; private set; }
        public String publisher { get; private set; }
        public String isbn { get; private set; }
        public int itemID { get; }
        public int quantityOnHand { get; private set; }
        public int quantityOnOrder { get; private set; } = 0;
        public double price { get; private set; }
        private static int totalInventoryQuantity = 1;

        public Book(String firstNameAuthor, String lastNameAuthor, int quantityOnHand, String bookTitle, String publisher, String isbn, double price)
        {
            this.firstNameAuthor = firstNameAuthor;
            this.lastNameAuthor = lastNameAuthor;
            this.quantityOnHand = quantityOnHand;
            itemID = totalInventoryQuantity;
            totalInventoryQuantity++;
            this.bookTitle = bookTitle;
            this.publisher = publisher;
            this.isbn = isbn;
            this.price = price;
        }

        public void OrderBook(int howMany)
        {
            quantityOnOrder += howMany;
        }

        public void RemoveBook(int howMany)
        {
            quantityOnHand -= howMany;
        }

        public void AddBook(int howMany)
        {
            quantityOnHand += howMany;
        }

        public new string ToString()
        {
            return bookTitle + ": " + quantityOnHand;
        }
    }
}
