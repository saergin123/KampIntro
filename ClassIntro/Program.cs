using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kurs class ını kullanmak için böyle tanımlamak gerekiyor.
            // yoksa class ın özelliklerini kullanamayız.
            //kurs1.yazınca intelisence(.koyunca  kod bloğu)  KursAdi,Egitmen,IzlenmeOrani çıkıyor
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#"; //class ın değişkenlerine değer atamayı  burada -Main-  yapıyoruz
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 78;

            Kurs kurs2= new Kurs();
            kurs2.KursAdi = "Delphi"; 
            kurs2.Egitmen = "Ergin Öztürk";
            kurs2.IzlenmeOrani = 156;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java"; 
            kurs3.Egitmen = "Turabi Akyıldız";
            kurs3.IzlenmeOrani = 215;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };//Kurs[] kurslar = new Kurs[] { }; array tanımladım
            foreach (var b in kurslar)
            {
                Console.WriteLine(b.KursAdi+"  "+b.Egitmen +"   "+b.IzlenmeOrani);
            }
            

            Console.WriteLine(kurs2.KursAdi +" : Bu kurs "+kurs2.Egitmen +" tarafından verilmektedir. "+kurs2.IzlenmeOrani + "  kişi tarafından izlenmiştir.");


            Console.WriteLine("Hello World!");
        }
    }
    class Kurs //class yazıp tab tab yapınca bu kod bloğu çıkıyor.
    {
        //public int MyProperty { get; set; } prop yazınca sneped çıkıyor senin için tamamlayabilirim diyor tab tab kod bloğu çıkıyor
        public string KursAdi { get; set; }// 
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
