using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //nameing convention isimlendirme kuralı -Ekle- baş harf büyük kodun okunulurluğu için doğru yazma tekniği
        // Ekle(Urun malzeme) metot imzası aslında (Urun urun)daha iyi ama anlamak için böyle yazdım
        // parametre olarak Urun classını verdim- malzeme takma ismini verdim
        // -alias-baska bi takma isimde urun gibi  yazabiliriz.önemli değil
        public void Ekle(Urun malzeme)
        {
            Console.WriteLine("Tebrikler Sepete eklendi :" + malzeme.Adi); //+ stringe ekliyor
        }
    }
}
