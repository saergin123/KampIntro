using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2) //Topla(int sayi1, int sayi2) metot imzası-parantez içi parametre
        {
            //Topla(2,3) sayi1=2 sayi2=3
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Toplama sonucu:"+ toplam);// string haline otomatik getiriyor int toplam ifadesini çevirme yapmaya gerek yok
        }
    }
}
