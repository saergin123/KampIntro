using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Halil","Durmuş","Turabi" };//array tanımladık
            //Console.WriteLine(isimler[0]);//index numarası 0= 1.eleman Engin
            //Console.WriteLine(isimler[1]);//index numarası 1= 2.eleman Halil
            //Console.WriteLine(isimler[2]);//index numarası 2= 3.eleman Durmuş
            //Console.WriteLine(isimler[3]);//index numarası 3= 4.eleman Turabi
            ////dizilere(array)5.eleman ekleyemeyiz.Hiç eleman ekleyemeyiz dizimize program hata verir.new lersek eski elemanları kaybederiz.
            //isimler[4] = "Korkmaz";
            //Console.WriteLine(isimler[4]);//System.IndexOutOfRangeException: 'Index was outside the bounds of the array.' hatası alırız
            //                              //burada diyorki senin 4 elemanın var beşinci elemanı okumaya çalışıyorsun.Bu yüzden dizilerle çalışamıyoruz.
            //                              //C #'da   daha sonra array lerin geliştirilmiş hali koleksiyonlar dahil edilmiştir.

            List<string> isimler2 = new List<string> { "Engin", "Halil", "Durmuş", "Turabi" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Şahin"); //listemize  istediğimiz kadar yeni eleman ekleyebiliriz.
            Console.WriteLine("---5.eleman eklendi---");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
