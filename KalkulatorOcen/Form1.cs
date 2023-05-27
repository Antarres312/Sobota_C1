using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorOcen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_median_Click(object sender, EventArgs e)
        {
            // Zmienne
            List<int> oceny = new List<int>();

            int ocena;

            // 1. Zbieranie danych
            // matematyka
            if (int.TryParse(txt_matematyka.Text, out ocena))
            {
                if(ocena > 0 && ocena <= 6)
                {
                    oceny.Add(ocena);
                }
                else
                {
                    MessageBox.Show("Ocena z matematyki poza zakresem. Nie jest brana pod uwagę!"
                        , "Ocena poza zakresem"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
            // polski
            if (int.TryParse(txt_polski.Text, out ocena))
            {
                if (ocena > 0 && ocena <= 6)
                {
                    oceny.Add(ocena);
                }
                else
                {
                    MessageBox.Show("Ocena z polskiego poza zakresem. Nie jest brana pod uwagę!"
                        , "Ocena poza zakresem"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
            // angielski
            if (int.TryParse(txt_angielski.Text, out ocena))
            {
                if (ocena > 0 && ocena <= 6)
                {
                    oceny.Add(ocena);
                }
                else
                {
                    MessageBox.Show("Ocena z angielskiego poza zakresem. Nie jest brana pod uwagę!"
                        , "Ocena poza zakresem"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
            // biologia
            if (int.TryParse(txt_biologia.Text, out ocena))
            {
                if (ocena > 0 && ocena <= 6)
                {
                    oceny.Add(ocena);
                }
                else
                {
                    MessageBox.Show("Ocena z biologii poza zakresem. Nie jest brana pod uwagę!"
                        , "Ocena poza zakresem"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
            // geografia
            if (int.TryParse(txt_geografia.Text, out ocena))
            {
                if (ocena > 0 && ocena <= 6)
                {
                    oceny.Add(ocena);
                }
                else
                {
                    MessageBox.Show("Ocena z geografii poza zakresem. Nie jest brana pod uwagę!"
                        , "Ocena poza zakresem"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }

            if(oceny.Count == 0)
            {
                MessageBox.Show("Wprowadzono 0 poprawnych ocen!");
                return;
            }


            float srednia = (float)oceny.Sum() / oceny.Count;

            lbl_result.Text = "Liczba poprawnych ocen: " + oceny.Count + " Średnia: " + srednia;
            
            if(oceny.Min() == 1)
            {
                MessageBox.Show("Co za różnica, nie zdasz i tak. Spróbuj za rok :)", ":<"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }
    }
}
