using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1
{
    class ProductManager //PascalCase olarak yazılır class isimleri
    {
        //metotun nasıl çağrılacağını anllattığımız yer
        //metot imzası -void Add(Product product)- Product classından product türünde bişiy ver parametre olarak
        //encapsulation -soyutlama
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +"  Eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" Güncellendi");
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public  void Topla2(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Topla2 metodunun sonucu:  "+ toplam);
        }
    }
}
