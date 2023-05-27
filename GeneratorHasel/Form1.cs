using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorHasel
{
    public partial class Form1 : Form
    {
        const string lowercase = "qwertyuiopasdfghjklzxcvbnm";
        const string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
        const string numbers = "1234567890";
        const string specials = "!@#$%&";


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string valid = lowercase;

            if (cbx_numbers.Checked)
                valid += numbers;
            if (cbx_uppercase.Checked) 
                valid += uppercase;
            if (cbx_specials.Checked) 
                valid += specials;

            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < nud_length.Value; i++)
            {
                builder.Append(valid[random.Next(valid.Length)]);
            }
            tbx_password.Text = builder.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbx_password.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory= true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, tbx_password.Text);
            }
        }
    }
}
