using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaMniejszychLiczb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Obliczmamy sumę wszystkich mniejszych liczb naturalnych. 
            int suma = 0;
            int liczba =(int) nup_number.Value;

            for (int i = 1; i < liczba; i++)
            {
                suma += i;
            }



            MessageBox.Show($"Suma wszystkich liczb mniejszych od podanej wynosi {suma}",$"Obliczono sumę dla {liczba}",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
