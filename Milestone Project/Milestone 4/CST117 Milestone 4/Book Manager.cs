using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_Milestone_4
{
    public class Book_Manager
    {
        //Creates an array of Book objects.
        private List<Book> _bookInventory = new List<Book>();

        //The array is then filled with books.
        public Book_Manager()
        {
            _bookInventory.Add(new Book("J.K.Rowling", 50, "Harry Potter and the Sorcerer's Stone", "Scholastic", "9780590353427", 8.89m));
            _bookInventory.Add(new Book("Frank Herbert", 20, "Dune", "Ace", "0441172717", 8.99m));
            _bookInventory.Add(new Book("J.R.R.Tolkein", 40, "The Hobbit", "Houghton Mifflin Harcourt", " 0547928246", 10.67m));
            _bookInventory.Add(new Book("Mark Twain", 25, "The Adventures of Tom Sawyer", "SeaWolf Press", "194813280X", 7.75m));
            _bookInventory.Add(new Book("Robert Louis Stevenson ", 15, "Treasure Island", "CreateSpace Independent Publishing Platform", "1514650460", 6.85m));
            _bookInventory.Add(new Book("John Bunyan", 30, "The Pilgrim's Promise", "Wentworth Press", "137430672X", 21.95m));
            _bookInventory.Add(new Book("Wilson Rawls", 10, "Where the Red Fern Grows", "Delacorte Books for Young Readers", "0399551239", 11.89m));
        }

        //Adds a book and increases the final inventory index.
        public void addBook(String author, int quantityOnHand, String bookTitle, String publisher, String isbn, decimal price)
        {
            _bookInventory.Add(new Book(author, quantityOnHand, bookTitle, publisher, isbn, price));
        }

        //Removes a book and decreases the final inventory index.
        public void removeItem(int index)
        {
            _bookInventory.RemoveAt(index);
        }

        //A book object is restocked with the given quantity.
        public void restockItem(int index, int quantity)
        {
            _bookInventory[index].AddBook(quantity);
        }

        //Method displays a single book
        public Book getBook(int index)
        {
            return _bookInventory[index];
        }

        //Searches the inventory by Book Title and Quantity and then displays the index of the item.
        //-1 returns an error if there is none found.
        public int searchInventory(string searchCriteria, string lookingFor)
        {
            int foundIndex = -1;

            switch (searchCriteria)
            {
                case "Book Title":

                    for (int index = 0; index < _bookInventory.Count; index++)
                    {
                        if (_bookInventory[index].bookTitle == lookingFor)
                        {
                            foundIndex = index;
                        }
                    }

                    break;

                case "Quantity":

                    for (int index = 0; index < _bookInventory.Count; index++)
                    {
                        if (_bookInventory[index].quantityOnHand == int.Parse(lookingFor))
                        {
                            foundIndex = index;
                        }
                    }

                    break;

                case "Author":

                    for (int index = 0; index < _bookInventory.Count; index++)
                    {
                        if (_bookInventory[index].author == lookingFor)
                        {
                            foundIndex = index;
                        }
                    }

                    break;

                case "ISBN":

                    for (int index = 0; index < _bookInventory.Count; index++)
                    {
                        if (_bookInventory[index].isbn == lookingFor)
                        {
                            foundIndex = index;
                        }
                    }

                    break;

                case "Publisher":

                    for (int index = 0; index < _bookInventory.Count; index++)
                    {
                        if (_bookInventory[index].publisher == lookingFor)
                        {
                            foundIndex = index;
                        }
                    }

                    break;

                case "Item ID":

                    for (int index = 0; index < _bookInventory.Count; index++)
                    {
                        if (_bookInventory[index].quantityOnHand == int.Parse(lookingFor))
                        {
                            foundIndex = index;
                        }
                    }

                    break;

                case "Price":

                    for (int index = 0; index < _bookInventory.Count; index++)
                    {
                        if (_bookInventory[index].quantityOnHand == decimal.Parse(lookingFor))
                        {
                            foundIndex = index;
                        }
                    }

                    break;
            }
            return foundIndex;
        }

        public int NumberOfElements
        {
            get { return _bookInventory.Count; }
        }
    }
}
