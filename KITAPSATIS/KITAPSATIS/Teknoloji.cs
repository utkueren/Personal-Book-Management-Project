using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KITAPSATIS
{
    public class Teknoloji : Kitap,Ozetci
    {
        public string ozet()
        {
            return "TEKNOLOJİ:Günümüzün teknoloji olaylarını takip etmek isterseniz veya teknoloji dünyasının içine girmek isterseniz buradan başlamalısınız." +
                "Kendinize ait bir web site nasıl yaparsınız?," +
                "Mobil uygulama nasıl yazılır?," +
                "Yapay Zeka dünyamızda hangi seviyede? " +
                "Bu soruların ve birçoğunun cevabını arıyorsanız doğru yerdesiniz.";
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", kitapad, yazar, sayfasay, yayinevi, baski, tur);//// format Plaka + şeklinde yazıp uzatmayı engeller
        }
    }
}
