using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T> 
    {
         T[] items; //BOŞ ARRAY OLUŞTURDUM
        

        public MyList() 
        {
            items = new T[0];//O ELEMANLI BİR ARRAY OLUŞTURDUM
        }
        public void Add(T item) 
        {
            //geçici dizi(tempArray oluşturup diz asağıda
            //new leyince yeni referans numarası alıyor.eskisinin içindeki eleman gidiyor
            //dizideki(items adlı dizi)elemanları gecici Olarak tempArray isimli dizide saklıyorum

            T[] tempArray = items;

            items = new T[items.Length + 1]; //Dizinin eleman sayısını 1 artırıyoruz.

            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];
            }
            
            items[items.Length - 1] = item;
            //items in eleman sayısı 3 ise index nosu 2 olur.
            //1.elemanın index nosu sıfırdır 1=[0] birinci elemanı yazdırmak istersek [0] yazmalıyız
            //2.elemanın index nosu birdir   2=[1] onun için  items[items.Length - 1] = item; bir çıkarttık
            //3.elemanın index nosu ikidir   3=[2]
            Console.WriteLine(item); 
            //ekran da
            //Engin
            //Durmuş
            //Turabi
            //Ali  yazar
        }

    }
}
