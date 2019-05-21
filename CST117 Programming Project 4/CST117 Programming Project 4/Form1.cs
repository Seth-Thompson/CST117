using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Programming_Project_4
{
    public partial class CST117ProgrammingProject4 : Form
    {
        int turn;
        int click1, click2, click3, click4, click5, click6, click7, click8, click9;
        String btn1txt, btn2txt, btn3txt, btn4txt, btn5txt, btn6txt, btn7txt, btn8txt, btn9txt;



        String winner;


        public CST117ProgrammingProject4()
        {
            InitializeComponent();
        }

        private void CST117ProgrammingProject4_Load(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }

        private void BindToUI()
        {// refresh UI using values stored in variables
            btn1.Text = btn1txt;
            btn2.Text = btn2txt;
            btn3.Text = btn3txt;
            btn4.Text = btn4txt;
            btn5.Text = btn5txt;
            btn6.Text = btn6txt;
            btn7.Text = btn7txt;
            btn8.Text = btn8txt;
            btn9.Text = btn9txt;
            lblWinner.Text = winner;
        }

        private void ResetUIValues()
        {
            turn = 1;
            click1 = 0;
            click2 = 0;
            click3 = 0;
            click4 = 0;
            click5 = 0;
            click6 = 0;
            click7 = 0;
            click8 = 0;
            click9 = 0;
            btn1txt = "";
            btn2txt = "";
            btn3txt = "";
            btn4txt = "";
            btn5txt = "";
            btn6txt = "";
            btn7txt = "";
            btn8txt = "";
            btn9txt = "";
            winner = "";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn1txt = "X";
                    click1++;
                }
                else
                {
                    btn1txt = "O";
                    click1++;
                }
                turn++;
            }
            CheckForWinner();
            BindToUI();
        }

        private void Btn2_Click_1(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn2txt = "X";
                    click2++;
                }
                else
                {
                    btn2txt = "O";
                    click2++;
                }
                turn++;
            }
            CheckForWinner();
            BindToUI();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn3txt = "X";
                    click3++;
                }
                else
                {
                    btn3txt = "O";
                    click3++;
                }
                turn++;
            }
            CheckForWinner();
            BindToUI();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn4txt = "X";
                    click4++;
                }
                else
                {
                    btn4txt = "O";
                    click4++;
                }
                turn++;
            }
            CheckForWinner();
            BindToUI();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn5txt = "X";
                    click5++;
                }
                else
                {
                    btn5txt = "O";
                    click5++;
                }
                turn++;
            }
            CheckForWinner();
            BindToUI();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn6txt = "X";
                    click6++;
                }
                else
                {
                    btn6txt = "O";
                    click6++;
                }
                turn++;
            }
            CheckForWinner();
            BindToUI();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn7txt = "X";
                    click7++;
                }
                else
                {
                    btn7txt = "O";
                    click7++;
                }
                turn++;
            }
            CheckForWinner();
            BindToUI();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn8txt = "X";
                    click8++;
                }
                else
                {
                    btn8txt = "O";
                    click8++;
                }
                turn++;
            }
            CheckForWinner();
            BindToUI();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    btn9txt = "X";
                    click9++;
                }
                else
                {
                    btn9txt = "O";
                    click9++;
                }
                turn++;
            }
            CheckForWinner();
            BindToUI();
        }

        public void CheckForWinner()
        {
            if (btn1txt != "" && btn2txt != "" && btn3txt != "")
            {
                if (btn1txt == btn2txt && btn1txt == btn3txt)
                {
                    if (btn1txt == "X")
                    {
                        winner = "Player 1";
                    }
                    else
                    {
                        winner = "Player 2";
                    }

                }
            }
            if (btn4txt != "" && btn5txt != "" && btn6txt != "")
            {
                if (btn4txt == btn5txt && btn4txt == btn6txt)
                {
                    if (btn4txt == "X")
                    {
                        winner = "Player 1";
                    }
                    else
                    {
                        winner = "Player 2";
                    }
                }
            }
            if (btn7txt != "" && btn8txt != "" && btn9txt != "")
            {
                if (btn7txt == btn8txt && btn7txt == btn9txt)
                {
                    if (btn7txt == "X")
                    {
                        winner = "Player 1";
                    }
                    else
                    {
                        winner = "Player 2";
                    }
                }
            }
            if (btn1txt != "" && btn4txt != "" && btn7txt != "")
            {
                if (btn1txt == btn4txt && btn1txt == btn7txt)
                {
                    if (btn1txt == "X")
                    {
                        winner = "Player 1";
                    }
                    else
                    {
                        winner = "Player 2";
                    }
                }
            }
            if (btn2txt != "" && btn5txt != "" && btn8txt != "")
            {
                if (btn2txt == btn5txt && btn2txt == btn8txt)
                {
                    if (btn2txt == "X")
                    {
                        winner = "Player 1";
                    }
                    else
                    {
                        winner = "Player 2";
                    }
                }
            }
            if (btn3txt != "" && btn6txt != "" && btn9txt != "")
            {
                if (btn3txt == btn6txt && btn3txt == btn9txt)
                {
                    if (btn3txt == "X")
                    {
                        winner = "Player 1";
                    }
                    else
                    {
                        winner = "Player 2";
                    }
                }
            }
            if (btn1txt != "" && btn5txt != "" && btn9txt != "")
            {
                if (btn1txt == btn5txt && btn1txt == btn9txt)
                {
                    if (btn1txt == "X")
                    {
                        winner = "Player 1";
                    }
                    else
                    {
                        winner = "Player 2";
                    }
                }
            }
            if (btn3txt != "" && btn5txt != "" && btn7txt != "")
            {
                if (btn3txt == btn5txt && btn3txt == btn7txt)
                {
                    if (btn3txt == "X")
                    {
                        winner = "Player 1";
                    }
                    else
                    {
                        winner = "Player 2";
                    }
                }
            }
            if (winner != "")
            {
                click1++;
                click2++;
                click3++;
                click4++;
                click5++;
                click6++;
                click7++;
                click8++;
                click9++;
            }
        }

        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            ResetUIValues();
            BindToUI();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
