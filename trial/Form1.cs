using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] DaBoard = new string[9];
        int currentTurn = 0;

        public String returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }

        String combination = "";

        public void checkForWinner()
        {
            for (int i = 0; i < 8; i++)
            {

                switch (i)
                {
                    case 0:
                        combination = DaBoard[0] + DaBoard[4] + DaBoard[8];
                        result();//winning combination natin
                        break;
                    case 1:
                        combination = DaBoard[2] + DaBoard[4] + DaBoard[6];
                        result();//winning combination natin
                        break;
                    case 2:
                        combination = DaBoard[0] + DaBoard[1] + DaBoard[2];
                        result();//winning combination natin
                        break;
                    case 3:
                        combination = DaBoard[3] + DaBoard[4] + DaBoard[5];
                        result();//winning combination natin
                        break;
                    case 4:
                        combination = DaBoard[6] + DaBoard[7] + DaBoard[8];
                        result();//winning combination natin
                        break;
                    case 5:
                        combination = DaBoard[0] + DaBoard[3] + DaBoard[6];
                        result();//winning combination natin
                        break;
                    case 6:
                        combination = DaBoard[1] + DaBoard[4] + DaBoard[7];
                        result();//winning combination natin
                        break;
                    case 7:
                        combination = DaBoard[2] + DaBoard[5] + DaBoard[8];
                        result();//winning combination natin
                        break;
                }

            }
            checkDraw();
        }

        public void result()
        {
            if (combination == "OOO")
            {
                reset();
                MessageBox.Show("Si 0 ang nanalo sa laro!!!", "may nanalo na mga bes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (combination == ("XXX"))
            {
                reset();
                MessageBox.Show("Si X ang nanalo sa laro!!!", "may nanalo na mga bes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void reset()   //para sa reset natin hehe
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            DaBoard = new string[9];
            currentTurn = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        public void checkDraw()
        {
                int counter =0;
            for (int i = 0; i < DaBoard.Length; i++)
            {
                if(DaBoard[i] != null) {counter++;}
                if (counter==9)
                {
                    reset();
                    MessageBox.Show("Patas ang laban guys!!!", "Walang nanalo mga bes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            DaBoard[0] = returnSymbol(currentTurn);
            button1.Text = DaBoard[0];
            button1.Enabled = false;
            checkForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            DaBoard[1] = returnSymbol(currentTurn);
            button2.Text = DaBoard[1];
            button2.Enabled = false;
            checkForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            DaBoard[2] = returnSymbol(currentTurn);
            button3.Text = DaBoard[2];
            button3.Enabled = false;
            checkForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            DaBoard[3] = returnSymbol(currentTurn);
            button4.Text = DaBoard[3];
            button4.Enabled = false;
            checkForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            DaBoard[4] = returnSymbol(currentTurn);
            button5.Text = DaBoard[4];
            button5.Enabled = false;
            checkForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            DaBoard[5] = returnSymbol(currentTurn);
            button6.Text = DaBoard[5];
            button6.Enabled = false;
            checkForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            DaBoard[6] = returnSymbol(currentTurn);
            button7.Text = DaBoard[6];
            button7.Enabled = false;
            checkForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            DaBoard[7] = returnSymbol(currentTurn);
            button8.Text = DaBoard[7];
            button8.Enabled = false;
            checkForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            DaBoard[8] = returnSymbol(currentTurn);
            button9.Text = DaBoard[8];
            button9.Enabled = false;
            checkForWinner();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
