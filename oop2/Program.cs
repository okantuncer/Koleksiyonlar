using System;

namespace oop2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demirog";
            musteri1.TcNo = "12345678910";
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.SirketAdi= "Asas";
            musteri2.VergiNo = "1234567890";
            musteri2.Id = 2;
            musteri2.MusteriNo = "123457";

            Musteri musteri3 = new GercekMusteri();
            musteri3.Id = 5;


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(musteri1);
            customerManager.Add(musteri3);




        }
    }
}
