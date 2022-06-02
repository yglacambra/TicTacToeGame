namespace TicTacToeGame
{
    public partial class TicTacToeGame : Form
    {
        int Turn = 0;
        public TicTacToeGame()
        {
            InitializeComponent();
        }

        // code to ensure that the game cannot start when the textboxes are not filled
        private void TicTacToeGame_Load(object sender, EventArgs e)
        {
            {
                BtnTopLeft.Enabled = false;
                BtnTopCntr.Enabled = false;
                BtnTopRight.Enabled = false;
                BtnMidLeft.Enabled = false;
                BtnMidCntr.Enabled = false;
                BtnMidRight.Enabled = false;
                BtnBotCntr.Enabled = false;
                BtnBotLeft.Enabled = false;
                BtnBotRight.Enabled = false;
            }
        }
        private void BtnEnable()
        {
            {
                BtnTopLeft.Enabled = true;
                BtnTopCntr.Enabled = true;
                BtnTopRight.Enabled = true;
                BtnMidLeft.Enabled = true;
                BtnMidCntr.Enabled = true;
                BtnMidRight.Enabled = true;
                BtnBotCntr.Enabled = true;
                BtnBotLeft.Enabled = true;
                BtnBotRight.Enabled = true;
            }
        }
        //when you press enter after typing your name in the textbox
        private void TxtBoxPlyr1Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtBoxPlyr1Name.TextLength > 10)
                {
                    string MessagePrompt = "Maximum amount of characters exceeded. Please shorten your name.";
                    MessageBox.Show(MessagePrompt, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string MessagePrompt2 = "Are you sure that the name you inputted is correct?";
                    DialogResult MsgBoxResult = MessageBox.Show(MessagePrompt2, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (MsgBoxResult == DialogResult.Yes && TxtBoxPlyr2Name.Enabled == true)
                    {
                        TxtBoxPlyr1Name.Enabled = false;
                        TxtBoxPlyr1Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr1Name.BorderStyle = BorderStyle.None;
                    }
                    else if (MsgBoxResult == DialogResult.Yes)
                    {
                        TxtBoxPlyr1Name.Enabled = false;
                        TxtBoxPlyr1Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr1Name.BorderStyle = BorderStyle.None;
                        BtnEnable();
                    }
                }
            }
        }

        private void TxtBoxPlyr2Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtBoxPlyr2Name.TextLength > 10)
                {
                    string MessagePrompt = "Maximum amount of characters exceeded. Please shorten your name.";
                    MessageBox.Show(MessagePrompt, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string MessagePrompt2 = "Are you sure that the name you inputted is correct?";
                    DialogResult MsgBoxResult = MessageBox.Show(MessagePrompt2, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (MsgBoxResult == DialogResult.Yes && TxtBoxPlyr1Name.Enabled == true)
                    {
                        TxtBoxPlyr2Name.Enabled = false;
                        TxtBoxPlyr2Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr2Name.BorderStyle = BorderStyle.None;
                    }
                    else if (MsgBoxResult == DialogResult.Yes)
                    {
                        TxtBoxPlyr2Name.Enabled = false;
                        TxtBoxPlyr2Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr2Name.BorderStyle = BorderStyle.None;
                        BtnEnable();
                    }
                }
            }
        }

        private void BtnTopLeft_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnTopLeft.Text = "O";
                BtnTopLeft.Enabled = false;
                CheckingForAWinner();
            }
            else
            {
                ++Turn;
                BtnTopLeft.Text = "X";
                BtnTopLeft.Enabled = false;
                CheckingForAWinner();
            }
        }

        private void BtnTopCntr_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnTopCntr.Text = "O";
                BtnTopCntr.Enabled = false;
            }
            else
            {
                ++Turn;
                BtnTopCntr.Text = "X";
                BtnTopCntr.Enabled = false;
                CheckingForAWinner();
            }
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnTopRight.Text = "O";
                BtnTopRight.Enabled = false;
                CheckingForAWinner();
            }
            else
            {
                ++Turn;
                BtnTopRight.Text = "X";
                BtnTopRight.Enabled = false;
                CheckingForAWinner();
            }
        }

        private void BtnMidLeft_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnMidLeft.Text = "O";
                BtnMidLeft.Enabled = false;
                CheckingForAWinner();
            }
            else
            {
                ++Turn;
                BtnMidLeft.Text = "X";
                BtnMidLeft.Enabled = false;
                CheckingForAWinner();
            }
        }

        private void BtnMidCntr_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnMidCntr.Text = "O";
                BtnMidCntr.Enabled = false;
                CheckingForAWinner();
            }
            else
            {
                ++Turn;
                BtnMidCntr.Text = "X";
                BtnMidCntr.Enabled = false;
                CheckingForAWinner();
            }
        }

        private void BtnMidRight_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnMidRight.Text = "O";
                BtnMidRight.Enabled = false;
                CheckingForAWinner();
            }
            else
            {
                ++Turn;
                BtnMidRight.Text = "X";
                BtnMidRight.Enabled = false;
                CheckingForAWinner();
            }
        }

        private void BtnBotLeft_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnBotLeft.Text = "O";
                BtnBotLeft.Enabled = false;
                CheckingForAWinner();
            }
            else
            {
                ++Turn;
                BtnBotLeft.Text = "X";
                BtnBotLeft.Enabled = false;
                CheckingForAWinner();
            }
        }

        private void BtnBotCntr_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnBotCntr.Text = "O";
                BtnBotCntr.Enabled = false;
                CheckingForAWinner();
            }
            else
            {
                ++Turn;
                BtnBotCntr.Text = "X";
                BtnBotCntr.Enabled = false;
                CheckingForAWinner();
            }
        }

        private void BtnBotRight_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnBotRight.Text = "O";
                BtnBotRight.Enabled = false;
                CheckingForAWinner();
            }
            else
            {
                ++Turn;
                BtnBotRight.Text = "X";
                BtnBotRight.Enabled = false;
                CheckingForAWinner();
            }
        }

        private void CheckingForAWinner()
        {
            bool NoWinner = true;
            // vertical checks for X
            if (BtnTopLeft.Text == "X" && BtnMidLeft.Text == "X" && BtnBotLeft.Text == "X")
            {
                NoWinner = false;
                MsgBoxPlayer1Wins();
            }
            if (BtnTopCntr.Text == "X" && BtnMidCntr.Text == "X" && BtnBotCntr.Text == "X")
            {
                NoWinner = false;
                MsgBoxPlayer1Wins();
            }
            if (BtnTopRight.Text == "X" && BtnMidRight.Text == "X" && BtnBotRight.Text == "X")
            {
                NoWinner = false;
                MsgBoxPlayer1Wins();
            }

            //horizontal checks for X
            if (BtnTopLeft.Text == "X" && BtnTopCntr.Text == "X" && BtnTopRight.Text == "X")
            {
                NoWinner = false;
                MsgBoxPlayer1Wins();
            }
            if (BtnMidLeft.Text == "X" && BtnMidCntr.Text == "X" && BtnMidRight.Text == "X")
            {
                NoWinner = false;
                MsgBoxPlayer1Wins();
            }
            if (BtnBotLeft.Text == "X" && BtnBotCntr.Text == "X" && BtnBotRight.Text == "X")
            {
                NoWinner = false;
                MsgBoxPlayer1Wins();
            }

            //diagonal checks for X
            if (BtnTopLeft.Text == "X" && BtnMidCntr.Text == "X" && BtnBotRight.Text == "X")
            {
                NoWinner = false;
                MsgBoxPlayer1Wins();
            }
            if (BtnTopRight.Text == "X" && BtnMidCntr.Text == "X" && BtnBotLeft.Text == "X")
            {
                NoWinner = false;
                MsgBoxPlayer1Wins();
            }

            //vertical checks for O
            if (BtnTopLeft.Text == "O" && BtnMidLeft.Text == "O" && BtnBotLeft.Text == "O")
            {
                NoWinner = false;
                MsgBoxPlayer2Wins();
            }
            if (BtnTopCntr.Text == "O" && BtnMidCntr.Text == "O" && BtnBotCntr.Text == "O")
            {
                NoWinner = false;
                MsgBoxPlayer2Wins();
            }
            if (BtnTopRight.Text == "O" && BtnMidRight.Text == "O" && BtnBotRight.Text == "O")
            {
                NoWinner = false;
                MsgBoxPlayer2Wins();
            }

            //horizontal checks for O
            if (BtnTopLeft.Text == "O" && BtnTopCntr.Text == "O" && BtnTopRight.Text == "O")
            {
                NoWinner = false;
                MsgBoxPlayer2Wins();
            }
            if (BtnMidLeft.Text == "O" && BtnMidCntr.Text == "O" && BtnMidRight.Text == "O")
            {
                NoWinner = false;
                MsgBoxPlayer2Wins();
            }
            if (BtnBotLeft.Text == "O" && BtnBotCntr.Text == "O" && BtnBotRight.Text == "O")
            {
                NoWinner = false;
                MsgBoxPlayer2Wins();
            }

            //diagonal checks for O
            if (BtnTopLeft.Text == "O" && BtnMidCntr.Text == "O" && BtnBotRight.Text == "O")
            {
                NoWinner = false;
                MsgBoxPlayer2Wins();
            }
            if (BtnTopRight.Text == "O" && BtnMidCntr.Text == "O" && BtnBotLeft.Text == "O")
            {
                NoWinner = false;
                MsgBoxPlayer2Wins();
            }

            //To determine if there's a draw
            if (NoWinner == true && Turn == 9)
            {
                string DrawMsg = "It's a Draw! No one wins.";
                MessageBoxButtons DrawMsgBoxButtons = MessageBoxButtons.RetryCancel;
                MessageBoxIcon DrawMsgBoxIcon = MessageBoxIcon.Exclamation;
                DialogResult MsgBoxResult = MessageBox.Show(DrawMsg, "", DrawMsgBoxButtons, DrawMsgBoxIcon);
                if (MsgBoxResult == DialogResult.Retry)
                {
                    TicTacToeGame ResettedForm = new TicTacToeGame();
                    ResettedForm.Show();
                    this.Dispose(false);
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void MsgBoxPlayer1Wins()
        {
            MessageBoxButtons WinnerMsgBoxButtons = MessageBoxButtons.RetryCancel;
            string MsgPlayer1Wins = "Congrats, " + TxtBoxPlyr1Name.Text + "!" + " You Win!";
            DialogResult MsgBoxResult = MessageBox.Show(MsgPlayer1Wins,"", WinnerMsgBoxButtons);
            if (MsgBoxResult == DialogResult.Retry)
            {
                TicTacToeGame ResettedForm = new TicTacToeGame();
                ResettedForm.Show();
                this.Dispose(false);
            }
            else
            {
                this.Close();
            }
        }
        private void MsgBoxPlayer2Wins()
        {
            MessageBoxButtons WinnerMsgBoxButtons = MessageBoxButtons.RetryCancel;
            string MsgPlayer2Wins = "Congrats, " + TxtBoxPlyr2Name.Text + "!" + " You Win!";
            DialogResult MsgBoxResult = MessageBox.Show(MsgPlayer2Wins, "", WinnerMsgBoxButtons);
            if (MsgBoxResult == DialogResult.Retry)
            {
                TicTacToeGame ResettedForm = new TicTacToeGame();
                ResettedForm.Show();
                this.Dispose(false);
            }
            else
            {
                this.Close();
            }
        }
    }
}