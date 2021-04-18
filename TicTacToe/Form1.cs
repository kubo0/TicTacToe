using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            changeLabel();
        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(senderButton.Text.Contains("X") || senderButton.Text.Contains("O"))
            {
                return;
            }
            else
            {
                if (currentPlayer == CurrentPlayer.Cross)
                {
                    senderButton.Text = "X";
                    currentPlayer = CurrentPlayer.Circle;
                }
                else
                {
                    senderButton.Text = "O";
                    currentPlayer = CurrentPlayer.Cross;
                }
                checkWhoWins();
                changeLabel();
            }
        }

        public void changeLabel()
        {
            if(currentPlayer == CurrentPlayer.Cross)
            {
                currentLabel.Text = "Krzyżyk";
            }
            else
            {
                currentLabel.Text = "Kółko";
            }
        }

        public void clearTable()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for(int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                {
                    buttons[i].Text = "";
                }
            }
            currentPlayer = CurrentPlayer.Cross;
            changeLabel();
        }

        string winnerCross = "Gratulację! Krzyżyk wygrał!";
        string winnerCircle = "Gratulację! Kółko wygrało!";
        string gameWinner;

        public void checkWhatWins(string winner)
        {
            if (winner == "X")
            {
                MessageBox.Show(winnerCross, "Wygrana!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                clearTable();
            }
            else if (winner == "O")
            {
                MessageBox.Show(winnerCircle, "Wygrana!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                clearTable();
            }
        }

        public void checkWhoWins()
        {
            if(TopLeft.Text.Contains("X") && TopCentre.Text.Contains("X") && TopRight.Text.Contains("X"))
            {
                gameWinner = "X";
                checkWhatWins(gameWinner);
            }else if (TopLeft.Text.Contains("O") && TopCentre.Text.Contains("O") && TopRight.Text.Contains("O"))
            {
                gameWinner = "O";
                checkWhatWins(gameWinner);
            }else if (CentreLeft.Text.Contains("X") && CentreCentre.Text.Contains("X") && CentreRight.Text.Contains("X"))
            {
                gameWinner = "X";
                checkWhatWins(gameWinner);
            }else if (CentreLeft.Text.Contains("O") && CentreCentre.Text.Contains("O") && CentreRight.Text.Contains("O"))
            {
                gameWinner = "O";
                checkWhatWins(gameWinner);
            }else if (BottomLeft.Text.Contains("X") && BottomCentre.Text.Contains("X") && BottomRight.Text.Contains("X"))
            {
                gameWinner = "X";
                checkWhatWins(gameWinner);
            }else if (BottomLeft.Text.Contains("O") && BottomCentre.Text.Contains("O") && BottomRight.Text.Contains("O"))
            {
                gameWinner = "O";
                checkWhatWins(gameWinner);
            }else if (TopLeft.Text.Contains("X") && CentreLeft.Text.Contains("X") && BottomLeft.Text.Contains("X"))
            {
                gameWinner = "X";
                checkWhatWins(gameWinner);
            }else if (TopLeft.Text.Contains("O") && CentreLeft.Text.Contains("O") && BottomLeft.Text.Contains("O"))
            {
                gameWinner = "O";
                checkWhatWins(gameWinner);
            }else if (TopCentre.Text.Contains("X") && CentreCentre.Text.Contains("X") && BottomCentre.Text.Contains("X"))
            {
                gameWinner = "X";
                checkWhatWins(gameWinner);
            }else if (TopCentre.Text.Contains("O") && CentreCentre.Text.Contains("O") && BottomCentre.Text.Contains("O"))
            {
                gameWinner = "O";
                checkWhatWins(gameWinner);
            }else if (TopRight.Text.Contains("X") && CentreRight.Text.Contains("X") && BottomRight.Text.Contains("X"))
            {
                gameWinner = "X";
                checkWhatWins(gameWinner);
            }else if (TopRight.Text.Contains("O") && CentreRight.Text.Contains("O") && BottomRight.Text.Contains("O"))
            {
                gameWinner = "O";
                checkWhatWins(gameWinner);
            }else if (TopLeft.Text.Contains("X") && CentreCentre.Text.Contains("X") && BottomRight.Text.Contains("X"))
            {
                gameWinner = "X";
                checkWhatWins(gameWinner);
            }else if (TopLeft.Text.Contains("O") && CentreCentre.Text.Contains("O") && BottomRight.Text.Contains("O"))
            {
                gameWinner = "O";
                checkWhatWins(gameWinner);
            }else if (BottomLeft.Text.Contains("X") && CentreCentre.Text.Contains("X") && TopRight.Text.Contains("X"))
            {
                gameWinner = "X";
                checkWhatWins(gameWinner);
            }else if (BottomLeft.Text.Contains("O") && CentreCentre.Text.Contains("O") && TopRight.Text.Contains("O"))
            {
                gameWinner = "O";
                checkWhatWins(gameWinner);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearTable();
        }
    }
}
