using System;
using System.Linq;

namespace LINQFirstAny
{
    class Program
    {
        static void Main(string[] args)
        {
            var arabalar = new[]
            {
                new
                {
                    Id=100,
                    Marka="Ford",
                    Model="Kuga",
                    Motor=1.6,
                    Vites="Otomatik",
                    Renk="Beyaz"
                },
                new
                {
                    Id=100,
                    Marka="Ford",
                    Model="Focus",
                    Motor=1.5,
                    Vites="Manuel",
                    Renk="Mavi"
                },
                new
                {
                    Id=101,
                    Marka="Audi",
                    Model="A6",
                    Motor=2.5,
                    Vites="Otomatik",
                    Renk="Siyah"
                },
                new
                {
                    Id=102,
                    Marka="Seat",
                    Model="İbiza",
                    Motor=1.4,
                    Vites="Otomatik",
                    Renk="Kırmızı"
                },
            };

            var deger = arabalar.Where(araba => araba.Marka == "Ford").FirstOrDefault();
            Console.WriteLine(deger.Model);

            //Any()
            bool sonuc = arabalar.Any(araba => araba.Renk.ToUpper() == "mavi".ToUpper());
            if (sonuc)
            {
                Console.WriteLine("Aradığınız renkte araç en az bir tane var.");
            }
            else
            {
                Console.WriteLine("Aradığınız renkte araç yok.");
            }
            Console.ReadKey();
        }
    }
}
