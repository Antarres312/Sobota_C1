using System;
using System.Windows.Forms;

namespace KolkoIKrzyzyk
{
    public partial class Form1 : Form
    {
        public bool ruchGracza1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void Btn_NewGame_Click(object sender, EventArgs e)
        {

        }

        private bool SprawdzCzyKtosWygral()
        {
            // Pion
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                return true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                return true;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                return true;
            }
            // POZIOM
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                return true;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                return true;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                return true;
            }
            // Przekątne
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                return true;
            }
            else if (button7.Text == button5.Text && button5.Text == button3.Text && button7.Text != "")
            {
                return true;
            }

            return false;
        }

        private void WstawZnak(object przycisk)
        {
            Button wcisnietyPrzycisk = (Button)przycisk;

            if (ruchGracza1)
            {
                wcisnietyPrzycisk.Text = "X";
            }
            else
            {
                wcisnietyPrzycisk.Text = "0";

            }

            wcisnietyPrzycisk.Enabled = false;

            bool wynik = SprawdzCzyKtosWygral();

            DialogResult dialogResult;
            string messageText;
            if (wynik)
            {
                if (ruchGracza1)
                {
                    messageText = "Wygrał Gracz 1";
                }
                else
                {
                    messageText = "Wygrał Gracz 2";
                }
                dialogResult = MessageBox.Show(messageText, "Rozpocząć jeszcze raz?", MessageBoxButtons.YesNo);

                if(dialogResult == DialogResult.Yes)
                {
                    ResetujGre();
                    return;
                }

            }

            ruchGracza1 = !ruchGracza1;

            if (ruchGracza1)
                Lbl_turn.Text = "Gracz 1  |  X";
            else
                Lbl_turn.Text = "Gracz 2  |  O";
        }

        private void ResetujGre()
        {
            button1.Enabled = true;
            button2.Enabled= true;
            button3.Enabled= true;
            button4.Enabled= true;
            button5.Enabled= true;
            button6.Enabled= true;
            button7.Enabled= true;
            button8.Enabled= true;
            button9.Enabled= true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
    }
}
