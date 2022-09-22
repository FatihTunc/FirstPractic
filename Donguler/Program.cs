using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Kurs1 = "Yazılım gelistirici kampı";
            string Kurs2 = "Temel kurs";
            string Kurs3 = "Java kursu";

            string[]Kurslar=new string[] { "Yazılım gelistirici kampı", 
                "Temel kurs", "Java kursu","Busebal","Fatih","Badebal" };


            for (int i = 0; i < Kurslar.Length; i++)
            {
                Console.WriteLine(Kurslar[i]);

            } 
             

            Console.WriteLine("*********For Bitti!***********");


            foreach (string Kurs in Kurslar)
            {
                Console.WriteLine(Kurs);
            }
            Console.WriteLine("Sayfa Sonu");

        }

    }
}
