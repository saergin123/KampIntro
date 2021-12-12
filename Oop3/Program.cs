using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();

            KonutKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService fileLoggerService = new FileLoggerService();//new lemeden kullanamayız.instance

            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            ILoggerService smsLoggerService = new SmsLoggerService();

             List<ILoggerService> loggers = new List< ILoggerService> () {databaseLoggerService,fileLoggerService,smsLoggerService };

             basvuruManager.BasvuruYap(tasitKrediManager,loggers) ;

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
