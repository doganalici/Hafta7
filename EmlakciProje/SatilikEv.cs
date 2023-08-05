using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciProje
{
    public class SatilikEv:Ev
    {
        public double Fiyati { get; set; }

        public override void Baslik()
        {
            Console.WriteLine("*** SATILIK EV BİLGİLERİ ***");
        }
        public void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine($"Satış Fiyatı : {Fiyati}");
        }

    }
}
