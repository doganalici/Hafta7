using System;

namespace AutoPropertyOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            Araba araba = new Araba();
            araba.Marka = "Ford";
            araba.Model = "Focus";
            araba.Yil = 2004;
            araba.Yakit = "Benzin";
            araba.Kilometre = 123000;
            araba.Aciklama = "Sıfırdan farksız. İçerisinde sigara içilmemiş. Çizikten dolayı tamamı boyalı";

            araba.BilgileriYazdir();

            Araba araba2 = new Araba()
            {
                Marka = "Ford",
                Model = "Focus",
                Yil = 2004,
                Yakit = "Benzin",
                Kilometre = 123000,
                Aciklama = "Sıfırdan farksız. İçerisinde sigara içilmemiş. Çizikten dolayı tamamı boyalı"
            };

            araba2.BilgileriYazdir();

            Araba araba3 = new Araba()
            {
                Marka = "BMW",
                Model = "X3",
                Yil = 2020,
                Yakit = "Dİzel",
                Kilometre = 34000,
                Aciklama = "Tertemiz. Full +++ full"
            };

            araba3.BilgileriYazdir();

            Console.ReadKey();
        }
    }
}
