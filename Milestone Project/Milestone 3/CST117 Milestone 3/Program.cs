using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_Milestone_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book_Manager harryPotterBooks = new Book_Manager();

            Console.WriteLine("Your inventory: ");
            harryPotterBooks.displayInventory();

            harryPotterBooks.removeItem(6);

            Console.WriteLine("\nYour inventory after removing a book: ");
            harryPotterBooks.displayInventory();

            Console.WriteLine("\nRestocking on Harry Potter and the Sorcerer's Stone: ");
            harryPotterBooks.restockItem(0, 10);
            harryPotterBooks.displayInventory();

            Console.WriteLine("\nSearching for Harry Potter and the Prisoner of Azkaban: ");
            Console.WriteLine("\nThe following was returned after searching \"Harry Potter and the Prisoner of Azkaban\":");
            Console.WriteLine(harryPotterBooks.displayBook(harryPotterBooks.searchInventory("Book Title:", "Harry Potter and the Prisoner of Azkaban")));

            Console.WriteLine("\nSearching for books with a quantity of 20: ");
            Console.WriteLine("\nThe following was returned after searching \"Quantity of 20\":");
            Console.WriteLine(harryPotterBooks.displayBook(harryPotterBooks.searchInventory("Quantity:", "20")));

            Console.ReadLine();
        }
    }
}
