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
        byte currentTurn = 0;

        public String returnSymbol(byte turn)
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
            for (byte i = 0; i < 8; i++)
            {

                switch (i)
                {
                    case 0:
                        combination = DaBoard[0] + DaBoard[4] + DaBoard[8];
                        result();//winning combination natin (Diagonal)
                        break;
                    case 1:
                        combination = DaBoard[2] + DaBoard[4] + DaBoard[6];
                        result();//winning combination natin (Diagonal)
                        break;
                    case 2:
                        combination = DaBoard[0] + DaBoard[1] + DaBoard[2];
                        result();//winning combination natin (Horizontal)
                        break;
                    case 3:
                        combination = DaBoard[3] + DaBoard[4] + DaBoard[5];
                        result();//winning combination natin (Horizontal)
                        break;
                    case 4:
                        combination = DaBoard[6] + DaBoard[7] + DaBoard[8];
                        result();//winning combination natin (Horizontal)
                        break;
                    case 5:
                        combination = DaBoard[0] + DaBoard[3] + DaBoard[6];
                        result();//winning combination natin (Vertical)
                        break;
                    case 6:
                        combination = DaBoard[1] + DaBoard[4] + DaBoard[7];
                        result();//winning combination natin (Vertical)
                        break;
                    case 7:
                        combination = DaBoard[2] + DaBoard[5] + DaBoard[8];
                        result();//winning combination natin (Vertical)
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
                MessageBox.Show("Si 0 ang nanalo sa laro!!!", "may nanalo na mga bes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //pag si Y ang winner
            }
            else if (combination == ("XXX"))
            {
                reset();
                MessageBox.Show("Si X ang nanalo sa laro!!!", "may nanalo na mga bes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //pag si X ang winner
            }
        }

        public void reset()   
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
        // pag walang nanalo sa game
        public void checkDraw()
        {
                byte counter =0;
            for (byte i = 0; i < DaBoard.Length; i++)
            {
                if(DaBoard[i] != null) {counter++;}
                if (counter==9)
                {
                    reset();
                    MessageBox.Show("Patas ang laban guys!!!", "Walang nanalo mga bes!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        // para sa mga lalabas sa buttons natin
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
        // huling part hehe
        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Game!!");
            MessageBox.Show("Enjoy the Game!!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wag mag-away sa game");
            MessageBox.Show("Kung sino manalo kiss ko");
        }
    }
}
