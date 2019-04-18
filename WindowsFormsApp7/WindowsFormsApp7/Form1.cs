using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
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

        string deger = "Girilen Değer Bir Tc Kimlik Numarası Olabilir.";
        string deger2 = "Girilen Değer Bir Tc Kimlik Numarası Olamaz";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            string c, d;
            string sayı1 = textBox1.Text;
            string sayı2 = sayı1[sayı1.Length - 1].ToString();


            foreach (var i in sayı1)
            {
                c = i.ToString();

                toplam = toplam + int.Parse(c);
            }

            toplam = toplam - int.Parse(sayı2);

            d = toplam.ToString();

            d = d[d.Length - 1].ToString();

            if (d == sayı2)

                MessageBox.Show(deger);
            else

                MessageBox.Show(deger2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
