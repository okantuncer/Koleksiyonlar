using System;
using System.Collections.Generic;

namespace oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICrediManager crediManager, ILogerService logerService)
        {
            

            crediManager.Hesapla();
            logerService.Log();


        }


        public void KrediOnBilgilendirmesiYap(List<ICrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
