using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    //inheritance-TuzelMusteri classı  Musteri classından (ebeveyn)miras alır)tüzel müşteride bir müşteridir demek.Soyutlama 
    //Musteri classında olan özellikler artık TuzelMusteri classındada vardır.
    class TuzelMusteri : Musteri 
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
