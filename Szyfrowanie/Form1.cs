using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_process_Click(object sender, EventArgs e)
        {
            if(rbt_szyfrowanie.Checked)
            {
                txt_output.Text = Szyfruj(txt_input.Text,(int) NUD_przesuniecie.Value);
            } else
            {
                txt_output.Text = Deszyfrowanie(txt_input.Text,(int) NUD_przesuniecie.Value );
            }
        }

        #region Szyfrowanie

        public string Szyfruj(string input, decimal przesuniecie)
        {
            return Szyfruj(input,(int) przesuniecie);
        }
        public string Szyfruj(string input)
        {
            return Szyfruj(input, 1);
        }
        public string Szyfruj(string input, int przesuniecie)
        {
            string alfabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            string wynik = "";

            for (int licznik = 0; licznik < input.Length; licznik++)
            {
                char znak = input[licznik];

                int numerZnaku = alfabet.IndexOf(znak);

                if (numerZnaku == -1)
                {
                    wynik += znak;
                }
                else
                {
                    int nowyNumerZnaku = (numerZnaku + przesuniecie) % alfabet.Length;
                    char nowyZnak = alfabet[nowyNumerZnaku];
                    wynik += nowyZnak;
                }
            }
            return wynik;
        }

        public string Deszyfrowanie(string input, int przesuniecie)
        {
            string alfabet = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            string wynik = "";

            for (int licznik = 0; licznik < input.Length; licznik++)
            {
                char znak = input[licznik];

                int numerZnaku = alfabet.IndexOf(znak);

                if (numerZnaku == -1)
                {
                    wynik += znak;
                }
                else
                {
                    int nowyNumerZnaku = (numerZnaku + (alfabet.Length - przesuniecie)) % alfabet.Length;
                    char nowyZnak = alfabet[nowyNumerZnaku];
                    wynik += nowyZnak;
                }
            }
            return wynik;
        }

        public char SzyfrujZnak(char input, int przesuniecie)
        {
            string tarcza1 = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            string tarcza2 = "qwertyuiopasdfghjklzxcvbnmążźćśęłóń";
            if(tarcza1.IndexOf(input) == -1)
            {
                return input;
            } else
            {
                int index1 = tarcza1.IndexOf(input);
                index1 = (index1 + przesuniecie) % tarcza1.Length;
                char nowyZnak = tarcza1[index1];

                int index = tarcza2.IndexOf(nowyZnak);
                index = (index + przesuniecie) % tarcza2.Length;
                nowyZnak = tarcza2[index];

                return nowyZnak;
            }
        }

        #endregion
    }
}
