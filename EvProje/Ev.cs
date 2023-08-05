using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvProje
{
    class Ev
    {
        //field : alan, sınıf değişkenlerine denir
        //varsayılan erişim belirleyici private dır.
        public string turu { get; set; }
        public int odaSayisi { get; set; }
        public double metreKaresi { get; set; }
        public bool kiralikMi { get; set; }

        public Ev() //default constructor
        {
            Console.WriteLine("Default constructor çalıştı");
        }

        public Ev(string turu, int odaSayisi, double metreKaresi, bool kiralikMi) //parametreli constructor
        {
            this.turu = turu;
            this.odaSayisi = odaSayisi;
            this.metreKaresi = metreKaresi;
            this.kiralikMi = kiralikMi;
        }

        public Ev(Ev ev) //copy constructor
        {
            this.turu = ev.turu;
            this.odaSayisi = ev.odaSayisi;
            this.metreKaresi = ev.metreKaresi;
            this.kiralikMi = ev.kiralikMi;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine("--- EV BİLGİLERİ ---\n");
            Console.WriteLine($"Türü : {turu}\n" +
                              $"Oda sayısı : {odaSayisi}\n" +
                              $"Metre karesi :  {metreKaresi} m2");
            if (kiralikMi == true)
            {
                Console.WriteLine($"Kira Durumu : Evet\n");
            }
            else
            {
                Console.WriteLine($"Kira Durumu : Hayır\n");
            }
        }
    }
}

