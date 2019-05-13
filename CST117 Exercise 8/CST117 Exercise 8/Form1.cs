using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Exercise_8
{
    public partial class CST117Exercise8CalorieCalculator : Form
    {
        int fats;
        int carbohydrates;
        int fatCalories;
        int carbohydrateCalories;
        int totalCalories;

        public CST117Exercise8CalorieCalculator()
        {
            InitializeComponent();
        }

        private void CST117Exercise8CalorieCalculator_Load(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }

        private void BindFromUI()
        { // get values from UI and store in variables
            try
            {
                fats = Int32.Parse(txtbxFats.Text);
                carbohydrates = Int32.Parse(txtbxCarbohydrates.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindToUI()
        {// refresh UI using values stored in variables
            lblCaloriesFromFats.Text = "Total calories from fats are: " + FatCalories(fats).ToString();
            lblCaloriesFromCarbohydrates.Text = "Total calories from carbohydrates are: " + CarbCalories(carbohydrates).ToString();
            lblTotalCalories.Text = "Total calories from fats and carbohydrates are: " + totalCalories.ToString();
        }

        private void ResetUIValues()
        {
            fats = 0;
            carbohydrates = 0;
            fatCalories = 0;
            carbohydrateCalories = 0;
            totalCalories = 0;
        }

        private int FatCalories(int fats)
        {
            fatCalories = fats * 9;
            return fatCalories;
        }

        private int CarbCalories(int carbs)
        {
            carbohydrateCalories = carbs * 4;
            return carbohydrateCalories;
        }

        private void CalculateTotalCalories()
        {
            totalCalories = FatCalories(fats) + CarbCalories(carbohydrates);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            BindFromUI();
            CalculateTotalCalories();
            BindToUI();
        }
    }
}
