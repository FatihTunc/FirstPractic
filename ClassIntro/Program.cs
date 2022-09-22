using System;

namespace ClassIntro
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmeni = "CILGIN FETİİ";
            kurs1.İzlenmeOrani = 365;



            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java#";
            kurs2.Egitmeni = "waxciyan";
            kurs2.İzlenmeOrani = 001;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmeni = "Xarpiyet";
            kurs3.İzlenmeOrani = 023;
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                //Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmeni);
            }




        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
