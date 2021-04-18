using System;
using System.Collections.Generic;

namespace oop3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ICrediManager ihtiyacKrediManager = new İhtiyacKrediManager();


            ICrediManager konutKrediManager = new KonutKrediManager();


            ICrediManager tasitKrediManager = new TasitKrediManager();

            //ILogerService dataBaseLoggerService = new DataBaseLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DataBaseLoggerService());



            List<ICrediManager> krediler = new List<ICrediManager>() { ihtiyacKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
