using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_Milestone_4
{
    public class Book
    {
        public String author { get; set; }
        public String bookTitle { get; set; }
        public String publisher { get; set; }
        public String isbn { get; set; }
        public int itemID { get; }
        public int quantityOnHand { get; set; }
        public int quantityOnOrder { get; set; } = 0;
        public decimal price { get; set; }
        private static int totalInventoryQuantity = 1;

        public Book(String author, int quantityOnHand, String bookTitle, String publisher, String isbn, decimal price)
        {
            this.author = author;
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
