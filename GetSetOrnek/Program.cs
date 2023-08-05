using System;

namespace GetSetOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            kisi.Ad = "Doğan ALICI"; //set bloğu
            Console.WriteLine(kisi.Ad); //get bloğu

            kisi.Yas = -25;
            Console.WriteLine(kisi.Yas);

            kisi.Maas = 10000;
            kisi.Cinsiyet = 'E';

            Console.WriteLine(kisi.Maas);
            Console.WriteLine(kisi.Cinsiyet);


            Console.ReadKey();
        }
    }
}
