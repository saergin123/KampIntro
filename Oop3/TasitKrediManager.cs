using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class TasitKrediManager : IKrediManager// IKrediManager interfaceni(arabirimi uygula)implement edince aşağıdaki kod bloğunu hazırlıyor.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
