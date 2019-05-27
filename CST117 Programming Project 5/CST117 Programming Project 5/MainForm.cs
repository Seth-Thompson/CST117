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
    public partial class CST117ProgrammingProject5 : Form
    {
        int birthYear, monthNumber, birthDay, daysInMonth, generatedNumber = 0;

        

        private void CST117ProgrammingProject5_Load(object sender, EventArgs e)
        {
            //All years between 1900 and the current year are programmically added to the birth year combo box when the program loads.
            for (int i = 0; (DateTime.Now.Year - i) >= 1900; i++)
            {
                cmbbxYear.Items.Add(DateTime.Now.Year - i);
            }
            CalculateDays();
        }

        public CST117ProgrammingProject5()
        {
            InitializeComponent();
        }

        private void CalculateDays()
        {
            if (cmbbxDay.Enabled == true)
            {
                //finds and sets the currently selected year and month and stores them.
                cmbbxDay.Items.Clear();
                monthToNumber(this.cmbbxMonth.GetItemText(this.cmbbxMonth.SelectedItem));
                birthYear = DateTime.Now.Year - int.Parse(cmbbxYear.GetItemText(cmbbxYear.SelectedIndex));

                //These are used to calculate the number of days within a month.
                daysInMonth = DateTime.DaysInMonth(birthYear, monthNumber);

                for (int i = 1; i <= daysInMonth; i++)
                {
                    cmbbxDay.Items.Add(i);
                }
            }
        }

        private void CmbbxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDays();
        }

        private void CmbbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDays();
        }

        private void CmbbxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDay = cmbbxDay.SelectedIndex + 1;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbbxYear.SelectedIndex != -1 && cmbbxMonth.SelectedIndex != -1 && cmbbxDay.SelectedIndex != -1 && txtbxFavoriteColor.Text != "")
            {
                //Array is generated based upon characters listed as the favorite color.
                char[] favoriteColorArray = txtbxFavoriteColor.Text.ToCharArray();
                int trigger = 0;

                //The values are assembled randomly to produce a lucky number.
                generatedNumber = birthYear / (monthNumber * birthDay + 1);

                for (int i = 0; i < favoriteColorArray.Length; i++)
                {
                    if (trigger == 0)
                    {
                        generatedNumber += favoriteColorArray[i];
                        trigger++;
                    }
                    else if (trigger == 1)
                    {
                        generatedNumber = Math.Abs(generatedNumber - favoriteColorArray[i]);
                        trigger++;
                    }
                    else if (trigger == 2)
                    {
                        generatedNumber *= favoriteColorArray[i];
                        trigger++;
                    }
                    else if (trigger == 3)
                    {
                        generatedNumber /= favoriteColorArray[i];
                        trigger = 0;
                    }
                }

                //This random number is sent to the Lucky Number results form.
                LuckyNumberForm luckyNumberForm = new LuckyNumberForm(generatedNumber.ToString());
                luckyNumberForm.Show();
            }
            else
            {
                MessageBox.Show("Please fill out all forms before attempting to calculate.");
            }
        }

        //The string of the month name is converted into a matching number.
        private void monthToNumber(string monthName)
        {
            switch (monthName)
            {
                case "January":
                    monthNumber = 1;
                    break;
                case "February":
                    monthNumber = 2;
                    break;
                case "March":
                    monthNumber = 3;
                    break;
                case "April":
                    monthNumber = 4;
                    break;
                case "May":
                    monthNumber = 5;
                    break;
                case "June":
                    monthNumber = 6;
                    break;
                case "July":
                    monthNumber = 7;
                    break;
                case "August":
                    monthNumber = 8;
                    break;
                case "September":
                    monthNumber = 9;
                    break;
                case "October":
                    monthNumber = 10;
                    break;
                case "November":
                    monthNumber = 11;
                    break;
                case "December":
                    monthNumber = 12;
                    break;
                default:
                    monthNumber = -1;
                    break;

            }
        }
    }
}
