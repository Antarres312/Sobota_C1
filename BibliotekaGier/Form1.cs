using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaGier
{
    public partial class Form1 : Form
    {
        // publiczne zmienne 
        // prywatne zmienne
        // konstruktor
        // metody

        // rodzaj zmiennej[] nazwaZmiennej = new rodzja zmiennej[długość];
        // rodzaj zmiennej[] nazwaZmiennej = {elementy, oddzielone, przecinkami};

        Gra[] gry = new Gra[4];

        public Form1() //  <---- konstruktor
        {
            InitializeComponent();

            gry[0] = new Gra("Fortnite","Fortnite to taka gra dla dzieci.", 81, 0);
            gry[1] = new Gra("HoMM3", "Najlepsza gra i koniec.", 17, 99.99f);
            gry[2] = new Gra("War Thunder", "Samolociki robią pju pju.", 81, 0);
            gry[3] = new Gra("Minecraft","Ja w to grałem jak miałem 3 lata. Genialna gra", 93, 98.69f);




            foreach (Gra tytul in gry)
            {
                lbx_tytuly.Items.Add(tytul.tytul);
            }

        }

        private void lbx_tytuly_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Tytul.Text = gry[lbx_tytuly.SelectedIndex].tytul;
            scoreBar.Value = gry[lbx_tytuly.SelectedIndex].ocena;
        }


    }

    public struct Gra
    {
        public string tytul;
        public string opis;
        public int ocena;
        public float cena;

        public Gra(string tytul, string opis, int ocena, float cena)
        {
            this.tytul = tytul;
            this.opis = opis;
            this.ocena = ocena;
            this.cena = cena;
        }
    }

}
