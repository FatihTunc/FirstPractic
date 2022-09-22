using System;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            {
                urun1.UrununAdi = "zaza";
                urun1.Aciklama = "cok guzel abiciyimmm";
                urun1.Fiyati = 23;
                urun1.Id = 3215;


            }
            Urun urun2 = new Urun();
            {
                urun2.UrununAdi = "ADANALI KIZ COKH HOJDIRR";
                urun2.Aciklama = "MANNAK YAA";
                urun2.Fiyati = 0101;
                urun2.Id = 1999.13;


            }
            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.UrununAdi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("ADIM ADIM GELİYORUM İNŞAALLAH");
                //Console.WriteLine(  "caz yapma moruqq");
            }
            Console.WriteLine("*******************Metotlar*********");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("basgan geliyeahh", "cok tatlısın cuzelsin", 2301);
        }
    }
}
