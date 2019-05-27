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
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (txtbxBookAuthor.Text != "" && txtbxBookCost.Text != "" && txtbxBookISBN.Text != "" && txtbxBookPublisher.Text != "" && txtbxBookQuantity.Text != "" && txtbxBookTitle.Text != "")
            {
                int quantity = Int32.Parse(txtbxBookQuantity.Text);
                decimal price = decimal.Parse(txtbxBookCost.Text, System.Globalization.NumberStyles.Currency);
                
                //add the item according to the text fields
                MainForm._workingManager.addBook(txtbxBookAuthor.Text, quantity, txtbxBookTitle.Text, txtbxBookPublisher.Text, txtbxBookISBN.Text,price);

                Close();
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
