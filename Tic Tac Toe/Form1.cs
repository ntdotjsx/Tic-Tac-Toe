namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool there_is_win = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                there_is_win = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                there_is_win = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                there_is_win = true;
            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                there_is_win = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                there_is_win = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                there_is_win = true;
            }


            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                there_is_win = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                there_is_win = true;
            }



            if (there_is_win)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }

                MessageBox.Show(winner + " Win!!!");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("OOP! Try again");
                }
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    NewGame.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
            }
            catch { }
        }

        private void A2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkForWinner();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                    NewGame.Text = "New Game";
                    button1.Text = "About";
                    button2.Text = "Exit";
                }
            }
            catch { }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                }
                else
                {
                    b.Text = "O";
                }
            }
        }
        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanapon IT02");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}