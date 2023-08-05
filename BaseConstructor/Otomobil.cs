using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructor
{
    //this : içerisinde bulunulan sınıfın nesnesini referans eder
    //base : ata sınıfın nesnesini referans eder
    class Otomobil : Arac // kalıtım 
    {
        public Otomobil() : base()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Otomobil sınıfının kurucu metodu.");
        }
    }
}
