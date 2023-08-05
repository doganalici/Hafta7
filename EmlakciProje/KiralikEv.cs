using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciProje
{
    public class KiralikEv:Ev
    {
        public double Depozito { get; set; }
        public double Kira { get; set; }

        public override void Baslik()
        {
            Console.WriteLine("*** KİRALIK EV BİLGİLERİ ***");
        }
        public void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine($"Depozito : {Depozito}\n" +
                              $"Kira : {Kira}");
        }

        
    }
}
