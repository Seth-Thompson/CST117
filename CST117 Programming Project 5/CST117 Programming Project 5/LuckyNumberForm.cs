using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Programming_Project_5
{
    public partial class LuckyNumberForm : Form
    {
        public LuckyNumberForm(String luckyNumber)
        {
            InitializeComponent();
            lblLuckyNumber.Text = luckyNumber;
        }

        private void LuckyNumberForm_Load(object sender, EventArgs e)
        {
        }
    }
}
