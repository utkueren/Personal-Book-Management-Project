using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace KITAPSATIS
{
    public class Tarih : Kitap, Ozetci
    {
        public string ozet()
        {
            return "TARİH:geçmişte yaşamış insanların hayatlarına ortak olmakisterseniz tarih türündeki kitapları seçmelisiniz istanbulun fethinden," +
                "cumhuriyetin kuruluşuna kadar birçok olay sizi bekliyor.";
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", kitapad, yazar, sayfasay, yayinevi, baski, tur);//// format Plaka + şeklinde yazıp uzatmayı engeller
        }
    }
}
