using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_Milestone_3
{
    class Book_Manager
    {
        //Creates an array of Book objects.
        Book[] bookInventory = new Book[10];
        private int inventoryFinalIndex = 0;

        //The array is then filled with books.
        public Book_Manager()
        {
            bookInventory[0] = new Book("J.K.", "Rowling", 10, "Harry Potter and the Sorcerer's Stone", "Scholastic", "9780590353427", 2.00);
            bookInventory[1] = new Book("J.K.", "Rowling", 20, "Harry Potter and the Chamber of Secrets", "Scholastic", "9781856136129", 2.00);
            bookInventory[2] = new Book("J.K.", "Rowling", 10, "Harry Potter and the Prisoner of Azkaban", "Scholastic", "9782740417959", 2.00);
            bookInventory[3] = new Book("J.K.", "Rowling", 10, "Harry Potter and the Goblet of Fire", "Scholastic", "9789985312094", 2.00);
            bookInventory[4] = new Book("J.K.", "Rowling", 10, "Harry Potter and the Order of the Phoenix", "Scholastic", "9783551354051", 2.00);
            bookInventory[5] = new Book("J.K.", "Rowling", 10, "Harry Potter and the Half-Blood Prince", "Scholastic", "9784863892453", 2.00);
            bookInventory[6] = new Book("J.K.", "Rowling", 10, "Harry Potter and the Deathly Hallows", "Scholastic", "9780747595861", 2.00);
            inventoryFinalIndex = 7;
        }

        //Adds a book and increases the final inventory index.
        public void addBook(String firstNameAuthor, String lastNameAuthor, int quantityOnHand, String bookTitle, String publisher, String isbn, double price)
        {
            bookInventory[inventoryFinalIndex] = new Book(firstNameAuthor, lastNameAuthor, quantityOnHand, bookTitle, publisher, isbn, price);
            inventoryFinalIndex++;
        }

        //Removes a book and decreases the final inventory index.
        public void removeItem(int index)
        {
            //The array loops to find the book at the index point and removes it from the array.
            for (int i = 0; (i + index) <= (bookInventory.Length - 1); i++)
            {
                if (index + i == bookInventory.Length - 1)
                {
                    //The book is removed.
                    bookInventory[index + i] = null;
                }
                else
                {
                    //The array is resized to fit the new array.
                    bookInventory[index + i] = bookInventory[index + i + 1];
                }
            }
            inventoryFinalIndex--;
        }

        //A book object is restocked with the given quantity.
        public void restockItem(int index, int quantity)
        {
            bookInventory[index].AddBook(quantity);
        }

        //All of the books are displayed on the console.
        public void displayInventory()
        {
            for (int i = 0; i < inventoryFinalIndex; i++)
            {
                Console.WriteLine(bookInventory[i].ToString());
            }
        }

        //Method displays a single book
        public string displayBook(int index)
        {
            return bookInventory[index].ToString();
        }

        //Searches the inventory by Book Title and Quantity and then displays the index of the item.
        //-1 returns an error if there is none found.
        public int searchInventory(string searchCriteria, string lookingFor)
        {
            switch (searchCriteria)
            {
                case "Book Title:":

                    for (int index = 0; index < bookInventory.Length; index++)
                    {
                        if (bookInventory[index].bookTitle == lookingFor)
                        {
                            return index;
                        }

                        if (index == bookInventory.Length - 1)
                        {
                            return -1;
                        }
                    }

                    break;

                case "Quantity:":

                    for (int index = 0; index < bookInventory.Length; index++)
                    {
                        if (bookInventory[index].quantityOnHand == int.Parse(lookingFor))
                        {
                            return index;
                        }

                        if (index == bookInventory.Length - 1)
                        {
                            return -1;
                        }
                    }

                    break;
            }
            return -1;
        }
    }
}
