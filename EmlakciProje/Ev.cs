using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciProje
{
    public class Ev
    {
        public int Id { get; set; }
        public double Alan { get; set; }
        public int KatNo { get; set; }
        public int OdaSayisi { get; set; }
        public string Adres { get; set; }

        public void Yazdir()
        {
            string bilgi =
                $"---- EV BİLGİLERİ ----\n" +
                $"Id : {Id}\n" +
                $"Alan : {Alan}\n" +
                $"KatNo : {KatNo}\n" +
                $"Oda Sayısı : {OdaSayisi}\n" +
                $"Adres : {Adres}";
            Console.WriteLine(bilgi);
        }
        public virtual void Baslik()
        {
            Console.WriteLine("---EV BİLGİLERİ---");
        }

    }
}
