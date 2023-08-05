using System;

namespace EvProje
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev ev = new Ev();
            Console.WriteLine();
            ev.turu = "Konut";
            ev.odaSayisi = 4;
            ev.metreKaresi = 145.50;
            ev.kiralikMi = true;
            ev.BilgileriYazdir();

            
            Ev ev2 = new Ev("Daire", 3, 105, false);
            ev2.BilgileriYazdir();

            Ev ev3 = new Ev("Konut",4,200.44,true);
            Ev copyEv = new Ev(ev3);
            copyEv.BilgileriYazdir();
            Console.ReadKey();
        }
    }
}
