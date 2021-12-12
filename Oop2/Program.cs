using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "8696";
            musteri1.TcNo = "12345678";
            musteri1.Adi = "Engin";
            musteri1.Soyadi ="Demiroğ";
            
            Console.WriteLine(musteri1.Adi);
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5874";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "4785214";
            Console.WriteLine(musteri2.SirketAdi);
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri(); // base(temel)sınıf referans tutucudur.Musteri classı onu inherit eden GercekMusteri ve TuzelMusteri classlarının referansını tutar.
            MusteriManager musteriManager = new MusteriManager();//new lemeden kullanamam
            musteriManager.Ekle(musteri1);//görüldüğü gibi hepsini ekleme yapabiliyoruz.
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
