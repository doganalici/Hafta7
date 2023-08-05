using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropertyOrnek
{
    class Araba
    {
        //AUTO PROPERTY
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Yakit { get; set; }
        public int Kilometre { get; set; }
        public string Aciklama { get; set; }

        public void BilgileriYazdir()
        {
            string bilgi = $"Araç Marka : {Marka}\n" +
                           $"Model : {Model}\n" +
                           $"Yıl : {Yil}\n" +
                           $"Yakıt : {Yakit}\n"+
                           $"Kilometre : {Kilometre}\n" +
                           $"Açıklama : {Aciklama}";

            Console.WriteLine($"\n----- ARAÇ BİLGİLERİ ----\n\n{bilgi}");

        }

    }
}
