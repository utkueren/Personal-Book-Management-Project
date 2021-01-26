using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KITAPSATIS
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void oztro_Click(object sender, EventArgs e)
        {
            Roman ozetR = new Roman();
            MessageBox.Show(ozetR.ozet());
        }

        private void oztta_Click(object sender, EventArgs e)
        {
            Tarih ozetT = new Tarih();
            MessageBox.Show(ozetT.ozet());
        }

        private void oztte_Click(object sender, EventArgs e)
        {
            Teknoloji ozetTE = new Teknoloji();
            MessageBox.Show(ozetTE.ozet());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rbkotu.Checked)
            {
                Kötü kötü = new Kötü();

                listkit.Items.Add(kötü.degerlendirme());
            }
            if (rborta.Checked)
            {
                Orta orta = new Orta();
                listkit.Items.Add(orta.degerlendirme());
                
            }
            if (rbguzel.Checked)
            { 
                Güzel güzel = new Güzel();


                listkit.Items.Add(güzel.degerlendirme());
            }

            if (RB1.Checked) {
                string tur1 = "Roman";
                Kitap roman = new Roman();
                roman.tur = tur1;
                roman.kitapad = txtkad.Text;
                roman.yazar = txtYa.Text;
                roman.sayfasay = txtSS.Text ;
                roman.yayinevi = txtye.Text;
                roman.baski = txtbs.Text;
                listkit.Items.Add(roman);
            }
            if (RB2.Checked)
            {
                Kitap tarih= new Tarih();
                string tur2 = "Tarih";
                tarih.tur = tur2;
                tarih.kitapad = txtkad.Text;
                tarih.yazar = txtYa.Text;
                tarih.sayfasay = txtSS.Text;
                tarih.yayinevi = txtye.Text;
                tarih.baski = txtbs.Text;
                listkit.Items.Add(tarih);
            }
            if (RB3.Checked)
            {
                Kitap teknoloji = new Teknoloji();
                string tur3 = "Teknoloji";
                teknoloji.tur = tur3;
                teknoloji.kitapad = txtkad.Text;
                teknoloji.yazar = txtYa.Text;
                teknoloji.sayfasay = txtSS.Text;
                teknoloji.yayinevi = txtye.Text;
                teknoloji.baski = txtbs.Text;
                listkit.Items.Add(teknoloji);
            }
        }

        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void RB2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listkit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) { 
        
            
        }
    }
}
