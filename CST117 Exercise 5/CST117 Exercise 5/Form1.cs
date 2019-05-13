using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Exercise_5
{
    public partial class CST117Exercise5ApproximatePi : Form
    {
        int termCount;
        String termResults;
        String calculationResults;

        public CST117Exercise5ApproximatePi()
        {
            InitializeComponent();
        }

        private void CST117Exercise5ApproximatePi_Load(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }

        private void BindFromUI()
        { // get values from UI and store in variables
            try
            {
                termCount = int.Parse(txtbxTerms.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindToUI()
        {// refresh UI using values stored in variables
            txtbxTerms.Text = termCount.ToString();
            lblInputReflection.Text = termResults;
            lblCalculation.Text = calculationResults;
        }

        private void ResetUIValues()
        {
            termCount = 0;
            termResults = "";
            calculationResults = "";
        }

        private double CalculatePi(int terms)
        {
            double pi = 0.0;
            double odd = 1.0;
            double alternate = 1.0;
            for (int i = 0; i < termCount; i++)
            {
                pi = pi + ((4.0 / odd) * alternate);
                alternate *= -1.0;
                odd += 2.0;
            }
            return pi;
        }

        private void CalculateResults()
        {
            termResults = "Approximate value of pi after " + termCount + " terms";
            calculationResults = " = " + CalculatePi(termCount);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            BindFromUI();
            CalculateResults();
            BindToUI();
        }
    }
}
