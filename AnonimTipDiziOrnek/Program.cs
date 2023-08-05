using System;

namespace AnonimTipDiziOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenciler = new[]
            {
                new
                {
                    Id=1,
                    Ad="Adem AKKUŞ",
                    Meslek="Bilgisayar Müh.",
                    Yas=40
                },
                new
                {
                    Id=2,
                    Ad="Zehra ÖZTÜRK",
                    Meslek="Matematikçi",
                    Yas=23
                },
                new
                {
                    Id=3,
                    Ad="Umut B. TER",
                    Meslek="Bilgisayar Müh.",
                    Yas=22
                },
                new
                {
                    Id=4,
                    Ad="Mehmet ÖZHAN",
                    Meslek="Bilgisayar Öğrencisi",
                    Yas=19
                },
                new
                {
                    Id=5,
                    Ad="Doğan ALICI",
                    Meslek="Bilgisayar Mühendisi",
                    Yas=25
                },
                new
                {
                    Id=6,
                    Ad="Veciye CEYHAN",
                    Meslek="Elektronik Müh.",
                    Yas=31
                },
            };

            Console.WriteLine("*** ÖĞRENCİ BİLGİLERİ ***\n");

            foreach (var ogr in ogrenciler)
            {
                Console.WriteLine($"Id : {ogr.Id}\n" +
                                  $"Ad : {ogr.Ad}\n" +
                                  $"Meslek : {ogr.Meslek}\n" +
                                  $"Yas : {ogr.Yas}\n");
            }


            Console.WriteLine("-------------------------\n\n");

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

            Console.WriteLine("*** ARAÇ BİLGİLERİ ***\n");

            foreach (var arac in arabalar)
            {
                Console.WriteLine($"Id : {arac.Id}\n" +
                                  $"Marka : {arac.Marka}\n" +
                                  $"Model : {arac.Model}\n" +
                                  $"Motor : {arac.Motor}\n" +
                                  $"Vites : {arac.Vites}\n" +
                                  $"Renk : {arac.Renk}\n");
            }

            Console.WriteLine();
            Console.WriteLine($"Sınıf Adı : {arabalar.GetType().Name}");
            Console.WriteLine($"Base (Ata) Sınıf Adı : {arabalar.GetType().BaseType}");
            Console.WriteLine($"Properties (Özellikleri) : {arabalar.ToString()}");

            var ev = new
            {
                Id = 111,
                Turu = "Kiralık",
                OdaSayisi = 3,
                KatNo = 4,
                Kira = 5000
            };

            Console.WriteLine();
            Console.WriteLine($"Sınıf Adı : {ev.GetType().Name}");
            Console.WriteLine($"Base (Ata) Sınıf Adı : {ev.GetType().BaseType}");
            Console.WriteLine($"Properties (Özellikleri) : {ev.ToString()}");
            Console.ReadKey();
        }
    }
}
