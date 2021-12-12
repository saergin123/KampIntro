using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
           
            krediManager.Hesapla();
            foreach (var logger in loggerServices)
            {
                logger.Log();//her bir loglayıcıyı çalıştır(SmsLoggerService,DataLoggerService,FileLoggerService)
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla(); 
            }
        }
    }
}
