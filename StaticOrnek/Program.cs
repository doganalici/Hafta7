using System;

namespace StaticOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi("Adem AKKUŞ", 40, 100000.44);
            Console.WriteLine(kisi1.ToString());
            Kisi kisi2 = new Kisi("Adem AKKUŞ", 40, 100000.44);
            Console.WriteLine(kisi2.ToString());
            

            Console.WriteLine(Kisi.sayac);


            Console.ReadKey();
        }
    }
}
