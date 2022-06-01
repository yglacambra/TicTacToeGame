namespace TicTacToeGame
{
    public partial class TicTacToeGame : Form
    {
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
                    DialogResult Result = MessageBox.Show(MessagePrompt2, "", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        TxtBoxPlyr1Name.Enabled = false;
                        TxtBoxPlyr1Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr1Name.BorderStyle = BorderStyle.None;
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
                    DialogResult Result = MessageBox.Show(MessagePrompt2, "", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        TxtBoxPlyr2Name.Enabled = false;
                        TxtBoxPlyr2Name.TextAlign = HorizontalAlignment.Center;
                        TxtBoxPlyr2Name.BorderStyle = BorderStyle.None;
                    }
                }
            }
        }
    }
}