using System;

namespace FuncOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //anonim fonksiyonlar Fun ile ifade edilir.
            // Func<tip1,tip2,.....,tip15,tip16,tip17> isim()=>donusdegeri
            //tip1,tip2,.....tip16 : parametreler,  tip17 : dönüş tipi

            Func<int, int, int> topla = (x, y) => x + y;
            Console.WriteLine(topla(11, 22));

            Func<int, int, bool> esitmi = (a, b) => (a == b);
            Console.WriteLine(esitmi(11, 12));
            Console.WriteLine(esitmi(12, 12));
            Console.WriteLine();
            Func<int, int> karesi = (x) => x * x;
            Console.WriteLine(karesi(12));
            Console.WriteLine();
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(karesi(i));
            }
            Console.ReadKey();
        }


    }
}
