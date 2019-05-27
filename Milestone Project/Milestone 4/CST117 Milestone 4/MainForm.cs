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
    public partial class MainForm : Form
    {
        public static Book_Manager _workingManager = new Book_Manager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetList();
        }

        public void ResetList()
        {
            lstbxBookInventory.Items.Clear();

            for (int i = 0; i < _workingManager.NumberOfElements; i++)
            {
                Book singleItem = _workingManager.getBook(i);
                lstbxBookInventory.Items.Add(singleItem.ToString());
            }

            if (lstbxBookInventory.SelectedIndex == -1)
            {
                lstbxBookInventory.SelectedIndex = 0;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Add_Book _addBook = new Add_Book();
            _addBook.ShowDialog();
            ResetList();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Remove_Book _removeBook = new Remove_Book(lstbxBookInventory.SelectedIndex);
            _removeBook.SetConfirmMessage(_workingManager.getBook(lstbxBookInventory.SelectedIndex));
            _removeBook.ShowDialog();
            ResetList();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            int index;
            String outputMessage;

            index = lstbxBookInventory.SelectedIndex;
            outputMessage = "Book Author: " + _workingManager.getBook(index).author + 
                            "\nItem Quantity: " + _workingManager.getBook(index).quantityOnHand +
                            "\nItem ID: " + _workingManager.getBook(index).itemID +
                            "\nBook Title: " + _workingManager.getBook(index).bookTitle +
                            "\nPublisher: " + _workingManager.getBook(index).publisher +
                            "\nISBN: " + _workingManager.getBook(index).isbn +
                            "\nPrice: $" + _workingManager.getBook(index).price;
            MessageBox.Show(outputMessage);
        }

        private void BtnRestock_Click(object sender, EventArgs e)
        {
            Restock_Book _restockBook = new Restock_Book(_workingManager.getBook(lstbxBookInventory.SelectedIndex));
            _restockBook.SetAskMessage(_workingManager.getBook(lstbxBookInventory.SelectedIndex));
            _restockBook.ShowDialog();
            ResetList();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String criteria = cmbbxCriteria.Text;
            String lookingFor = txtbxLookingFor.Text;
            lstbxBookInventory.SetSelected(_workingManager.searchInventory(criteria, lookingFor), true);
        }
    }
}
