using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 111222;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Fatih";
            musteri1.Soyadi = "Tunc";
            musteri1.TcNo = "223323";

            TuzelMusteri musteri2 = new     TuzelMusteri();
            musteri2.Id = 789456;
            musteri2.MusteriNo = "1";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1489264578";
            
        }
    }
}
