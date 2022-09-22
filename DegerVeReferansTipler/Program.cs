using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //Bunlar  değer tiptir stackte donup dururlar (int,double,bool)
            //arraylar,classslar, interfaceler bunalr ie referans tiplerdi stackten heape veri aktarırlar.
        }
    }
}
