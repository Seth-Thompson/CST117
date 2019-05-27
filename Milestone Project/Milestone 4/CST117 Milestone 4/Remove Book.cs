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
    public partial class Remove_Book : Form
    {
        int bookIndex;
        public Remove_Book(int selectedIndex)
        {
            InitializeComponent();
            bookIndex = selectedIndex;
        }

        private void Remove_Book_Load(object sender, EventArgs e)
        {
            
        }

        public void SetConfirmMessage(Book book)
        {
            lblConfirm.Text = "Are you sure you wish to remove " + book.bookTitle + " from this list?";
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            MainForm._workingManager.removeItem(bookIndex);
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
