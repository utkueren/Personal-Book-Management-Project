using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace KITAPSATIS
{
    public class Kötü:Puanlama
    {
        public override string degerlendirme()
        {
            MessageBox.Show("Beklentimi karşılamayan bir kitaptı. İlgimi çekmedi.");
            return "KÖTÜ";
        }
    }
}
