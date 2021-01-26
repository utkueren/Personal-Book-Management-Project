using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace KITAPSATIS
{
    public class Roman : Kitap, Ozetci
    {
        public string ozet()
        {
            return "ROMAN:Olmuş ya da olabilir nitelikteki olayları ve konuları ele alan edebî türlere Roman denir." +
                   " Diğer türlerden ayrılan en önemli özelliği, uzunluğudur. " +
                   "Romanlarda, toplumsal olaylar ve ilişkiler gerçeklere uygun bir tarzda ele alınır.";
        }
      
        public override string ToString()
        { 
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", kitapad, yazar, sayfasay, yayinevi,baski,tur);//// format Plaka + şeklinde yazıp uzatmayı engeller
        }
    }
}
