using System;

namespace InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.AlanHesapla(3, 4);
            dikdortgen.CevreHesapla(3, 4);
            Console.ReadKey();
        }
    }
}
