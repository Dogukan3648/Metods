﻿namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            string[] meyveler = new string[] { };

           Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 17;

            Urun urun2 = new Urun();
            urun2.Id = 2;  
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.stokAdedi = 10;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("*************");

            }

            Console.WriteLine("--------Metodlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);


        }
    }
}