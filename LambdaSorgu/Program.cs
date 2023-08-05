using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaSorgu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 2, 3, 0, 4, 11, 13, 14, 8, 21, 23, 41 };
            //Count(sart) : şartı sağlayan durumların toplamını verir
            int tekAdet = sayilar.Count(n => n % 2 == 1);
            Console.WriteLine($"Dizide {tekAdet} tek sayı bulunmaktadır");
            int ciftAdet = sayilar.Count(n => n % 2 == 0);
            Console.WriteLine($"Dizide {ciftAdet} çift sayı bulunmaktadır");

            int[] kucukSayilar = sayilar.Where(n => n < 10).ToArray();
            //List<int> kucukSayilar2 = sayilar.Where(n => n < 10).ToList();
            foreach (var el in kucukSayilar)
            {
                Console.Write(el+" ");
            }

            Console.ReadKey();
        }
    }
}
