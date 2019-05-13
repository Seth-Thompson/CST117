using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Exercise_1
{
    public partial class Exercise1 : Form
    {

        String name = "";

        public Exercise1()
        {
            InitializeComponent();
        }

        private void Exercise1_Load(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }

        private void BindFromUI()
        { // get values from UI and store in variables
            name = txtBxName.Text;
        }


        private void BindToUI()
        {// refresh UI using values stored in variables
            txtBxName.Text = name;
            lblDisplayName.Text = txtBxName.Text;
        }

        private void ResetUIValues()
        {
            name = "";
        }

        private void BtnDisplayName_Click(object sender, EventArgs e)
        {
            BindFromUI();
            BindToUI();
        }

        private void BtnClearName_Click(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }
    }
}
