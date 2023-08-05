using System;

namespace KalitimOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ata ata = new Ata();
            ata.MetotAta();

            Cocuk cocuk = new Cocuk();
            cocuk.MetotAta();
            cocuk.MetotCocuk();
            
            Console.ReadKey();
        }
    }
}
