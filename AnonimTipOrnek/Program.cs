using System;

namespace AnonimTipOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //anonim tip : dosya karşılığı olmayan,
            //sadece RAM ' de oluşturulan tiplerdir.
            //kod zamanında türü belli olmadığından 
            //tür yerine var anahtar kelimesini yazıyoruz.

            var kisi = new
            {
                Id = 1,
                Ad = "Doğan",
                Soyad = "ALICI",
                Meslek = "Bilgisayar Müh.",
                Yas = 25
            };
            Console.WriteLine(kisi.Ad);
            Console.WriteLine(kisi.Soyad);
            Console.WriteLine(kisi.Meslek);
            Console.WriteLine(kisi.Yas);
            //kisi.Ad = null; //read-only olduğundan null değeri atanamaz
            //kisi.Ad = "Kerem"; //read-only olduğundan değeri değiştirilemez
            Console.WriteLine("----------------");
            var araba = new
            {
                Id = 100,
                Marka = "Ford",
                Model = "Focus",
                Motor = 1.6,
                Renk = "Beyaz",
                Km = 10000
            };
            Console.WriteLine(araba.Id);
            Console.WriteLine(araba.Marka);
            Console.WriteLine(araba.Model);
            Console.WriteLine(araba.Motor);
            Console.WriteLine(araba.Renk);
            Console.WriteLine(araba.Km);
            //araba.Renk = null; //read-only olduğundan null değeri atanamaz
            //araba.Renk = "Siyah"; //read-only olduğundan değeri değiştirilemez


            var ogrenci = new
            {
                Id = 11,
                Adi = "Veciye CEYHAN",
                Meslek = "Elekronik Müh.",
                Adres = new { Id = 1001, Il = "Yozgat", Ilce = "Şefaatli", Semt = "Kale" }
            };

            Console.WriteLine(" ---- ÖĞRENCİ BİLGİLERİ ----\n");
            Console.WriteLine($"Adı : {ogrenci.Adi}\n" +
                              $"Meslek : {ogrenci.Meslek}\n" +
                              $"Adres : {ogrenci.Adres.Il} {ogrenci.Adres.Ilce} {ogrenci.Adres.Semt}");
            Console.ReadKey();
        }
    }
}
