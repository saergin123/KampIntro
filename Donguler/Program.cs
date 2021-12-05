using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //i=1 başlangıç değeri
            //i<10 bitiş değeri
            //i++ artış değeri bir bir artır
            //birden başla 10 dan küçük olduğu sürece bir bir artır
            //önce 1 iyazdırır döngü tekrar basa döner sonra iki bu şekilde devam eder.
            //i=i+2 yazarsak iki iki artır  i=i+1 bir bir artır

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Temel Seviye programlama Kursu";
            string kurs4 = "Delphi ileri seviye programlamaKursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            // tek tek tanımlamak yerine yukarıdaki gibi 
            //array-dizi de yazıyorum
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java  Kursu" };

            for (int i = 0; i < 3; i=i+1)
            {
                Console.WriteLine(kurslar[i]);//kurslar aray inin i elemanını yazdırıyorum
               
            }
            Console.WriteLine("Burası for i döngüsü ile yazılmıştır");

            for (int i = 0; i < kurslar.Length; i++)//kursların eleman sayısı kadar dön diyorum.array lerde 0 dan baslar sayma işlemi 0=1,1=2,2=3 olur
            {
                Console.WriteLine(kurslar[i]);//kurslar aray inin i ninci  elemanını yazdırıyorum önce 0 ,sonra1,sonra2 ci elemanın yazdırır.
            }
            Console.WriteLine("Burası kurslar.lenght döngüsü ile yazılmıştır");
            foreach (string a in kurslar)//kurslar ın içini tek tek dolaş -foreeach array - dizi temelli yapıları tek tek dönmeye yarıyor.
            {
                Console.WriteLine(a);//a yerine istediğimiz - alias -takma ismi yazabiliriz.alias  takma isimdir.
                
            }
            Console.WriteLine("Burası foreeach döngüsü ile yazılmıştır");
            Console.WriteLine("sayfa sonu-footer");

            for (int i = 1; i <10; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
