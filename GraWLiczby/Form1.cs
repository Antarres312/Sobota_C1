using System;
using System.Windows.Forms;

namespace GraWLiczby
{
    public partial class Form1 : Form
    {
        public int liczba1;
        public int liczba2;

        public char znak;

        private int maxLiczba = 100;

        public Form1()
        {
            InitializeComponent();
            LosujLiczby();
        }



        private void btn_sprawdz_Click(object sender, EventArgs e)
        {
            bool czyPoprawnie = false;

            if (int.TryParse(txt_wynik.Text, out int wynik))
            {

                if (znak == '+')
                {
                    if (wynik == liczba1 + liczba2)
                        czyPoprawnie = true;

                }
                else if (znak == '-')
                {
                    if (wynik == liczba1 - liczba2)
                        czyPoprawnie = true;

                }
                else
                {
                    if (wynik == liczba1 * liczba2)
                        czyPoprawnie = true;

                }

            }
            else
            {
                MessageBox.Show("To nie ma sensu");
                return;
            }


            if(czyPoprawnie)
            {
                MessageBox.Show("Brawo, jesteś mądry!", "Poprawnie", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Jednak nie jesteś mądry!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LosujLiczby();
            txt_wynik.Text = "";
        }




        // dostęp typZwrotny NazwaMetody (Argumenty) {}
        public void LosujLiczby()
        {
            Random rand = new Random();
            liczba1 = rand.Next(maxLiczba);
            liczba2 = rand.Next(maxLiczba);

            int nowyZnak = rand.Next(0, 3);

            if (nowyZnak == 0)
                znak = '+';
            else if (nowyZnak == 1)
                znak = '-';
            else
                znak = '*';

            lbl_rownanie.Text = liczba1 + " " + znak + " " + liczba2 + " =";
        }

    }
}
