using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -tip güvenliği
            //Do not repeat yourself
            //kategoriEtiketi bir değer tutucu-alias(takma isim)
            //intellisens-.yazınca açılan kod bloğu
            string kategoriEtiketi = "Kategori";
            int OgrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 12.15;
            double dolarBugun=12.78;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
                 Console.WriteLine(kategoriEtiketi);
        }
    }
}
