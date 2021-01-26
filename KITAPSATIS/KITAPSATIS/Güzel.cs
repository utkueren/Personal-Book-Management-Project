using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace KITAPSATIS
{
    public class Güzel:Puanlama
    {
        public override string degerlendirme()
        {
            MessageBox.Show("Etkileyici ve sürükleyici bir kitaptı. Okurken aynı zamanda yaşıyor gibiydim. Ufkumu oldukça genişletti. Öneriyorum.");
            return "GÜZEL";
        }
    }
}
