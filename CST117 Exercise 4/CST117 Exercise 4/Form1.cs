using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Exercise_4
{
    public partial class CST117Exercise4 : Form
    {
        int seconds;
        int minutes;
        int hours;
        int days;
        String outputMessage;

        public CST117Exercise4()
        {
            InitializeComponent();
        }

        private void CST117Exercise4_Load(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }

        private void BindFromUI()
        { // get values from UI and store in variables
            try
            {
                seconds = int.Parse(txtbxSeconds.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindToUI()
        {// refresh UI using values stored in variables
            txtbxSeconds.Text = seconds.ToString();
            lblOutput.Text = outputMessage;
        }

        private void ResetUIValues()
        {
            seconds = 0;
            minutes = 0;
            hours = 0;
            days = 0;
            outputMessage = "";
        }

        private String CalculateResults(int seconds)
        {
            int initialSeconds = seconds;

            if (seconds < 60 && seconds > 0)
                {
                    outputMessage = initialSeconds + " seconds are too small to be broken into anything.";
                }
                    else if (seconds < 3600 && seconds >= 60)
                    {
                        minutes = seconds / 60;
                        seconds = seconds % 60;
                        outputMessage = initialSeconds + " breaks into " + minutes + " minutes " + " and " + seconds + " seconds.";
                    }
                        else if (seconds < 86400 && seconds >= 3600)
                        {
                            hours = seconds / 3600;
                            seconds = seconds % 3600;
                            minutes = seconds / 60;
                            seconds = seconds % 60;
                            outputMessage = initialSeconds + " breaks into " + hours + " hours, " + minutes + " minutes, " + " and " + seconds + " seconds.";
                        }
                            else if (seconds >= 86400)
                            {
                                days = seconds / 86400;
                                seconds = seconds % 86400;
                                hours = seconds / 3600;
                                seconds = seconds % 3600;
                                minutes = seconds / 60;
                                seconds = seconds % 60;
                                outputMessage = initialSeconds + " breaks into " + days + " days, " + hours + " hours, " + minutes + " minutes, " + " and " + seconds + " seconds.";
                            }
            else
            {
                outputMessage = "";
                MessageBox.Show("You must enter a positive integer value that is greater than 0");
            }
            return outputMessage;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            BindFromUI();
            CalculateResults(seconds);
            BindToUI();
        }
    }
}
