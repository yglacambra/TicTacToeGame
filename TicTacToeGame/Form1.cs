namespace TicTacToeGame
{
    public partial class TicTacToeGame : Form
    {
        int Turn = 0;
        public TicTacToeGame()
        {
            InitializeComponent();
        }
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
                    DialogResult Result = MessageBox.Show(MessagePrompt2, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes && TxtBoxPlyr2Name.Enabled == true)
                    {
                        TxtBoxPlyr1Name.Enabled = false;
                        TxtBoxPlyr1Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr1Name.BorderStyle = BorderStyle.None;
                    }
                    else if (Result == DialogResult.Yes)
                    {
                        TxtBoxPlyr1Name.Enabled = false;
                        TxtBoxPlyr1Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr1Name.BorderStyle = BorderStyle.None;
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
                    DialogResult Result = MessageBox.Show(MessagePrompt2, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Result == DialogResult.Yes && TxtBoxPlyr1Name.Enabled == true)
                    {
                        TxtBoxPlyr2Name.Enabled = false;
                        TxtBoxPlyr2Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr2Name.BorderStyle = BorderStyle.None;
                    }
                    else if (Result == DialogResult.Yes)
                    {
                        TxtBoxPlyr2Name.Enabled = false;
                        TxtBoxPlyr2Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr2Name.BorderStyle = BorderStyle.None;
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
            }
        }

        private void BtnTopLeft_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnTopLeft.Text = "O";
                BtnTopLeft.Enabled = false;
            }
            else
            {
                ++Turn;
                BtnTopLeft.Text = "X";
                BtnTopLeft.Enabled = false;
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
            }
        }

        private void BtnTopRight_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnTopRight.Text = "O";
                BtnTopRight.Enabled = false;
            }
            else
            {
                ++Turn;
                BtnTopRight.Text = "X";
                BtnTopRight.Enabled = false;
            }
        }

        private void BtnMidLeft_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnMidLeft.Text = "O";
                BtnMidLeft.Enabled = false;
            }
            else
            {
                ++Turn;
                BtnMidLeft.Text = "X";
                BtnMidLeft.Enabled = false;
            }
        }

        private void BtnMidCntr_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnMidCntr.Text = "O";
                BtnMidCntr.Enabled = false;
            }
            else
            {
                ++Turn;
                BtnMidCntr.Text = "X";
                BtnMidCntr.Enabled = false;
            }
        }

        private void BtnMidRight_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnMidRight.Text = "O";
                BtnMidRight.Enabled = false;
            }
            else
            {
                ++Turn;
                BtnMidRight.Text = "X";
                BtnMidRight.Enabled = false;
            }
        }

        private void BtnBotLeft_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnBotLeft.Text = "O";
                BtnBotLeft.Enabled = false;
            }
            else
            {
                ++Turn;
                BtnBotLeft.Text = "X";
                BtnBotLeft.Enabled = false;
            }
        }

        private void BtnBotCntr_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnBotCntr.Text = "O";
                BtnBotCntr.Enabled = false;
            }
            else
            {
                ++Turn;
                BtnBotCntr.Text = "X";
                BtnBotCntr.Enabled = false;
            }
        }

        private void BtnBotRight_Click(object sender, EventArgs e)
        {
            if (Turn % 2 == 1)
            {
                ++Turn;
                BtnBotRight.Text = "O";
                BtnBotRight.Enabled = false;
            }
            else
            {
                ++Turn;
                BtnBotRight.Text = "X";
                BtnBotRight.Enabled = false;
            }
        }
        // code to ensure that the textboxes are filled up first before any game is started
        private void TicTacToeGame_Load(object sender, EventArgs e)
        {
            if (TxtBoxPlyr1Name.Enabled == true || TxtBoxPlyr2Name.Enabled == true)
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
    }
}