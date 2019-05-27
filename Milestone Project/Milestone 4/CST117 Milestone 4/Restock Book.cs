using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Milestone_4
{
    public partial class Restock_Book : Form
    {
        Book restockBook;

        public Restock_Book(Book book)
        {
            InitializeComponent();
            restockBook = book;
        }

        private void Restock_Book_Load(object sender, EventArgs e)
        {
            if (restockBook.quantityOnHand > 0)
            {
                MessageBox.Show("Warning: Restocking an item will reset the current quantity count." +
                                "\nThis will not take into account the currently stocked items." +
                                "\nYou currently have " + restockBook.quantityOnHand + " copies of " + restockBook.bookTitle + " on hand.");
            }
        }

        public void SetAskMessage(Book book)
        {
            lblAmoutAsk.Text = "How many copies of " + book.bookTitle + " are you restocking?";
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                restockBook.quantityOnHand = int.Parse(txtbxQuantity.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
