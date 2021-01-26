using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KITAPSATIS
{
    public partial class Giriş : Form
    {
        public static string kadi = "admin";
        public static string sifre = "123456";
        public Giriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sifre sif = new Sifre();

            if (textBox1.Text == sifre && txtkad.Text==kadi)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else { MessageBox.Show("Hatalı Kullanıcı adı veya şifre"); }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtkad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
