using System;

namespace Oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //instance -Product classının özeliklerini kullanabilmek için örneğini oluşturuyoruz.
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5,
                ProductName = "Kalem", UnitPrice = 35 }; //böylede yazabiliriz.

            //PascalCase    //camelCase   //case sensitive C# küçük büyük harf duyarlıdır.
            //Stack=  soltaraf değer tip    // = heap  sağ taraf referans tip
            //instance-ProductManager clasının özelliklerini kullanabilmek için örneğini oluşturuyoruz.
            ProductManager productManager = new ProductManager();
            
            //ProductManager classında metot imzası void Add(Product product ) ver diyor. buna uygun parametre verelim
            //metotumuzun çağrılması
            
            productManager.Add(product1);
            productManager.Update(product2);
            Console.WriteLine(product1.ProductName);
            productManager.Topla2(3,6); // ProductManager classındaki -public  void Topla2(int sayi1, int sayi2)-metoduna  parametre olarak (3,6) sayılarını gönderdik.

            //ProductManager classındaki-public int Topla(int sayi1,int sayi2)-metoduna parametre olarak(4,3)sayılarını gönderdik
            //4+3=7 sonucunu bize geri gönderdi(return)
            
            int toplamaSonucu = productManager.Topla(4,3);
           
            Console.WriteLine("return sonucu:"+toplamaSonucu);
            Console.WriteLine("Topla Metodunun return sonucu 7 yi 2 ile çarptık sonuç: "+toplamaSonucu * 2  + "  oldu");//gelen 7 sonucunu çarptırdık 2 sayısı ile
            Console.WriteLine(toplamaSonucu * 2);




        }
    }
}
