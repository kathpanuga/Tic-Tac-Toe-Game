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

        }
    }
}