using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Exercise_6
{
    public partial class CST117Exercise6DiceRoller : Form
    {
        List<string> _diceResults = new List<string>();

        public CST117Exercise6DiceRoller()
        {
            InitializeComponent();
        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            Dice dice1 = new Dice(6);
            dice1.DiceRoller();
            Dice dice2 = new Dice(6);
            dice2.DiceRoller();

            int count = 0;
            while(true)
            {
                dice1.DiceRoller();
                _diceResults.Add("Dice 1 rolled: " + dice1.sides.ToString());
                dice2.DiceRoller();
                _diceResults.Add("Dice 2 rolled: " + dice2.sides.ToString());

                if(dice1.sides == 1 && dice2.sides ==1)
                {
                    _diceResults.Add("Snake Eyes were rolled!");
                    _diceResults.Add("It took " + count + " dice rolls.");
                    lstbxRollResults.DataSource = _diceResults;
                    break;
                }

                count++;
            }
        }
    }
}
