using System;
using System.Runtime.Serialization;

namespace Kampİntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "Kategori";
            int OgrenciSayısı = 32000;
            double FaizOranı = 1.45;
            bool SistemeGirisYapmısMı = true;
            double Dolarındunkudegerı = 7.5;
            double Dolarınbugunkudegeri = 7.45;

            if (Dolarındunkudegerı>Dolarınbugunkudegeri)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (Dolarındunkudegerı<Dolarınbugunkudegeri)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Sabit butonu");
            }


            if (SistemeGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
                Console.ReadLine();
            }
            //Console.WriteLine("Sistem arızalı");
        }
    }
}

