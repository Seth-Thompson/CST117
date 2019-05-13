using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Exercise_3
{
    public partial class CST117Exercise3 : Form
    {
        double earthWeight = 0.000;
        double marsWeight = 0.000;
        public CST117Exercise3()
        {
            InitializeComponent();
        }

        private void CST117Exercise3_Load(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }

        private void BindFromUI()
        { // get values from UI and store in variables
            try
            {
                earthWeight = double.Parse(txtbxEarthWeight.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void BindToUI()
        {// refresh UI using values stored in variables
            txtbxEarthWeight.Text = earthWeight.ToString("f3");
            txtbxMarsWeight.Text = marsWeight.ToString("f3");
        }

        private void ResetUIValues()
        {
            earthWeight = 0.000;
            marsWeight = 0.000;
        }

        private double EarthWeightToMarsWeight(double earthWeight)
        {
            marsWeight = (earthWeight / 9.81) * 3.711;
            return marsWeight;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            BindFromUI();
            EarthWeightToMarsWeight(earthWeight);
            BindToUI();
        }
    }
}
