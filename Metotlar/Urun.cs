using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Urun 
    {
        //public erişim bildirgeci demektir.
        //property özellik demektir.ürün özellikleri ıd,adı ,fiyatı, açıklaması 

        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
    }
}
