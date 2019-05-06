using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Milestone_2
{
    public partial class CST117BookInventoryMilestone2 : Form
    {
        List<string> _bookDetails = new List<string>();

        public CST117BookInventoryMilestone2()
        {
            InitializeComponent();
        }

        private void CST117BookInventoryMilestone2_Load(object sender, EventArgs e)
        {
            Book newBook = new Book("J.K.", "Rowling", "Harry Potter and the Sorcerer's Stone", "Scholastic", "9780590353427");
            _bookDetails.Add(newBook.firstNameAuthor);
            _bookDetails.Add(newBook.lastNameAuthor);
            _bookDetails.Add(newBook.bookTitle);
            _bookDetails.Add(newBook.publisher);
            _bookDetails.Add(newBook.isbn);

            lstbxBooksInventory.DataSource = _bookDetails;
        }
    }
}
