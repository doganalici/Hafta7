using System;
using System.Linq;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=> ile ifade edilir
            //anonim bir tiptir
            //parametre alabilen ve geriye değer döndüren metotlar
            //lambda expression ile yazılabilir

            string gelen = Selamlama("Adem AKKUŞ");
            Console.WriteLine(gelen);

            //lambda expression ile
            //var gelen2 = (string name) => 
            //{ 
            //    return $"Merhaba, Sayın {name}";
            //};
            //Console.WriteLine(gelen2("Aden AKKUŞ");

            //
            int sonuc = Topla(5, 6);
            Console.WriteLine(sonuc);

            ////lambda expression ile
            //var sonuc2 = (int x, int y) =>
            //    {
            //        return x + y;
            //    };
            //Console.WriteLine(sonuc2(12,33));

            //var sonuc3 = (int x, int y) => x + y;
            //Console.WriteLine(sonuc3(22,23));

            //var sonuc4 = () => 13 % 4;
            //Console.WriteLine(sonuc4);

            Console.ReadKey();
        }
        //normal metot
        static string Selamlama(string name)
        {
            //string mesaj = $"Merhaba, sayın {name}";
            //return mesaj;
            return $"Merhaba, Sayın {name}";
        }

        //normal metot
        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
