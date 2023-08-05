using System;

namespace ClassOrnek
{
    class Ev
    {
        public Ev(string adi)
        {

        }
        public Ev()//default constructor
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Ev ev = new Ev(); //nesne oluşturduk
            Console.WriteLine(ev.GetType());
            Console.WriteLine(ev.GetType().Name);
            Console.ReadKey();
        }
    }
}
