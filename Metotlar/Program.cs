using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();// new le classın bir örneğini oluşturduk.yoksa Urun class nın içindekilere ulaşamayız.-İnstance- örnek oluşturduk.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 18;
            urun2.Aciklama = "çekirdeksiz armut";

            Urun urun3 = new Urun();
            urun3.Adi = "Kiraz";
            urun3.Fiyati = 20;
            urun3.Aciklama = "Hadim de yetişen kiraz";

            // Urun[] urunler = new Urun[] { };  urunler takma adlı-alias- Urun  array i oluşturdum.
            //foreach ile ürünleri  tek tek dolaşıp yazdırdım.

            Urun[] urunler = new Urun[] {urun1,urun2,urun3 };

            foreach (var urun in urunler)//urun yerine herhangi bir takma isim yazabiliriz.alias(x de olur a da)var yerine Urun class isminide yazabiliriz.
            {
                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------- çizgi çizgi yazdırdık");
            }

                Console.WriteLine("-------Metotlar-------");
            //İNSTANCE- Sepetmanager classının örneğini oluşturuyoruz.Ekle Metodunu çağırabilmek için
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);//public void Ekle(Urun malzeme) buradan gönderiyoruz Urun classının içindeki urun1=malzemeye gidiyor parametre olarak
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            
        }
    }
}
//Best practice doğru uygulama teknikleri
//Dont repeat your self- DRY-kendini tekrar etme
//Clean kod- type safe(foreach bloğu) tip güvenli 
//PascalCase-kelimelerin ilk harfi büyük yazılır. convension yazım kuralı
//CamelCase-ilk kelime küçük harf diğer kelimelerin ilk harfi büyük yazılır
