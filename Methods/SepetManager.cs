using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi"+"****" + urun.UrununAdi +"****"+ urun.Aciklama+"****" + urun.Fiyati);
        }
        public void Ekle2(string urunAdi, string aciklama , double Fiyat)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi" + urunAdi+aciklama+Fiyat );
        }
    }
}
