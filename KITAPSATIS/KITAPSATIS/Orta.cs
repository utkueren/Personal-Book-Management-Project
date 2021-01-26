using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace KITAPSATIS
{
    public class Orta:Puanlama
    {
        public override string degerlendirme()
        {
            MessageBox.Show("Yer yer sürükleyici olsa da beni kendine bağlayamayan bir kitaptı. İçeriğinin güzelliği bölümden bölüme değişti.");
            return "ORTA";
        }
    }
}
