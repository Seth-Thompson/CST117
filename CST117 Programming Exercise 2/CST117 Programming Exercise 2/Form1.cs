using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Programming_Exercise_2
{
    public partial class CST117ProgramingExercise2 : Form
    {
        String pizza;
        String pizzaType;
        String pizzaSize;
        String specialInstructions1;
        String specialInstructions2;
        String specialInstructions3;
        String specialInstructions4;
        String outputMessage;

        public CST117ProgramingExercise2()
        {
            InitializeComponent();
        }

        private void CST117ProgramingExercise2_Load(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }

        private void BindToUI()
        {// refresh UI using values stored in variables
            lblOutput.Text = outputMessage;
        }

        private void ResetUIValues()
        {
            pizza = "";
            pizzaType = "";
            pizzaSize = "";
            specialInstructions1 = "";
            specialInstructions2 = "";
            specialInstructions3 = "";
            specialInstructions4 = "";
            outputMessage = "";
        }

        private void RadiobtnSmall_CheckedChanged(object sender, EventArgs e)
        {
            pizzaSize = "small";
        }

        private void RadiobtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            pizzaSize = "medium";
        }

        private void RadiobtnLarge_CheckedChanged(object sender, EventArgs e)
        {
            pizzaSize = "large";
        }

        private void RadiobtnExtLarge_CheckedChanged(object sender, EventArgs e)
        {
            pizzaSize = "extra large";
        }

        private void PizzaChoice()
        {
            if (lstbxPizzas.SelectedIndex != -1)
            {
                pizza = lstbxPizzas.SelectedItem.ToString();
                switch (pizza)
                {
                    case "Cheese":
                        pizzaType = "cheese";
                        break;
                    case "Sausage":
                        pizzaType = "sausage";
                        break;
                    case "Pepperoni":
                        pizzaType = "pepperoni";
                        break;
                    case "Combo":
                        pizzaType = "combo";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Select a pizza.");
            }
        }

        private void SpecialInstructionSelections()
        {
            if (chxbxDoubleSauce.Checked)
            {
                specialInstructions1 = " with double sauce";
            }
            if (chxbxDoubleCheese.Checked)
            {
                specialInstructions2 = " with double cheese";
            }
            if (chxbxGlutenFree.Checked)
            {
                specialInstructions3 = " made gluten free";
            }
            if (chxbxToGo.Checked)
            {
                specialInstructions4 = " made to-go";
            }
        }

        private void PizzaOutput()
        {
            outputMessage = "You ordered a " + pizzaSize + " " + pizzaType + " pizza" + specialInstructions1 + specialInstructions2 + specialInstructions3 + specialInstructions4 + ".";
        }

        private void BtnMakePizza_Click(object sender, EventArgs e)
        {
            PizzaChoice();
            SpecialInstructionSelections();
            PizzaOutput();
            BindToUI();
        }
    }
}
