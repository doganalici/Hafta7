using System;

namespace EmlakciProje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev ev = new Ev()
            {
                Id = 0,
                Alan = 0,
                KatNo = 0,
                OdaSayisi = 0,
                Adres = "yok",
            };
            ev.Baslik();
            ev.Yazdir();
            KiralikEv kiralikEv = new KiralikEv()
            {
                Id = 1,
                Alan = 125,
                KatNo = 4,
                OdaSayisi = 3,
                Adres = "Yenimahalle",
                Depozito = 4000,
                Kira = 4000
            };
            kiralikEv.Baslik();
            kiralikEv.Yazdir();

            Console.WriteLine();

            SatilikEv satilikEv = new SatilikEv()
            {
                Id = 2,
                Alan = 145,
                KatNo = 10,
                OdaSayisi = 4,
                Adres = "Çankaya",
                Fiyati = 190000
            };
            satilikEv.Baslik();
            satilikEv.Yazdir();

            YeniEv yeniEv = new YeniEv();
            
            Console.ReadKey();
        }
    }
}
