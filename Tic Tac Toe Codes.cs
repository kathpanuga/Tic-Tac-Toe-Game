namespace Tic_Tac_Toe_Game_in_Visual_Basic
{
    public partial class Form1 : Form
    {
        bool turn = true;// true = X turn; false = O turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void disableButtons()
        {
            try
            {
                abc1.Enabled = false;
                abc2.Enabled = false;
                abc3.Enabled = false;
                cab1.Enabled = false;
                cab2.Enabled = false;
                cab3.Enabled = false;
                bac1.Enabled = false;
                bac1.Enabled = false;
                bac3.Enabled = false;
            }

            catch { }

        }
        private void abc1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;
            checkwinner();
        }

        private void abc2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;
            checkwinner();

        }

        private void abc3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;
            checkwinner();
        }

        private void cab1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;
            checkwinner();

        }

        private void cab2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;
            checkwinner();

        }

        private void cab3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;
            checkwinner();

        }

        private void bac1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;
            checkwinner();

        }

        private void bac2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;
            checkwinner();
        }

        private void bac3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";

            turn = !turn;
            btn.Enabled = false;
            turn_count++;
            checkwinner();
        }
        private void checkwinner()
        {
            bool there_is_a_winner = false;

            // diagonal checks
            if ((abc1.Text == cab2.Text) && (cab2.Text == bac3.Text) && (!abc1.Enabled))
            {
                abc1.BackColor = Color.LightCoral;
                cab2.BackColor = Color.LightCoral;
                bac3.BackColor = Color.LightCoral;
                there_is_a_winner = true;
            }
            if ((abc3.Text == cab2.Text) && (cab2.Text == bac1.Text) && (!abc3.Enabled))
            {
                abc3.BackColor = Color.LightCoral;
                cab2.BackColor = Color.LightCoral;
                bac1.BackColor = Color.LightCoral;
                there_is_a_winner = true;
            }

            // horizontal checks
            else if ((abc1.Text == abc2.Text) && (abc2.Text == abc3.Text) && (!abc1.Enabled))
            {
                abc1.BackColor = Color.OrangeRed;
                abc2.BackColor = Color.OrangeRed;
                abc3.BackColor = Color.OrangeRed;
                there_is_a_winner = true;
            }
            else if ((cab1.Text == cab2.Text) && (cab2.Text == cab3.Text) && (!cab1.Enabled))
            {
                cab1.BackColor = Color.OrangeRed;
                cab2.BackColor = Color.OrangeRed;
                cab3.BackColor = Color.OrangeRed;
                there_is_a_winner = true;
            }
            else if ((bac1.Text == bac2.Text) && (bac2.Text == bac3.Text) && (!bac1.Enabled))
            {
                bac1.BackColor = Color.OrangeRed;
                bac2.BackColor = Color.OrangeRed;
                bac3.BackColor = Color.OrangeRed;
                there_is_a_winner = true;
            }


            // vertical checks
            else if ((abc1.Text == cab1.Text) && (cab1.Text == bac1.Text) && (!abc1.Enabled))
            {
                abc1.BackColor = Color.PeachPuff;
                cab1.BackColor = Color.PeachPuff;
                bac1.BackColor = Color.PeachPuff;
                there_is_a_winner = true;
            }
            else if ((abc2.Text == cab2.Text) && (cab2.Text == bac2.Text) && (!abc2.Enabled))
            {
                abc2.BackColor = Color.PeachPuff;
                cab2.BackColor = Color.PeachPuff;
                bac2.BackColor = Color.PeachPuff;
                there_is_a_winner = true;
            }
            else if ((abc3.Text == cab3.Text) && (cab3.Text == bac3.Text) && (!abc3.Enabled))
            {
                abc3.BackColor = Color.PeachPuff;
                cab3.BackColor = Color.PeachPuff;
                bac3.BackColor = Color.PeachPuff;
                there_is_a_winner = true;
            }

            if (there_is_a_winner)
            {
                disableButtons();

                string winner = "";

                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " - Ah ah, Ikaw ang panalo!", "Paburger ka naman");
            }//end if
        }//end checkforwinner

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                abc1.Enabled = true;
                abc2.Enabled = true;
                abc3.Enabled = true;
                cab1.Enabled = true;
                cab2.Enabled = true;
                cab3.Enabled = true;
                bac1.Enabled = true;
                bac2.Enabled = true;
                bac3.Enabled = true;

                abc1.Text = "";
                abc2.Text = "";
                abc3.Text = "";
                cab1.Text = "";
                cab2.Text = "";
                cab3.Text = "";
                bac1.Text = "";
                bac2.Text = "";
                bac3.Text = "";
            }

            catch { }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

