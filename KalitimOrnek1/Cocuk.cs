using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOrnek1
{
    public class Cocuk : Ata
    {
        public string cocukAlan = "Çocuk sınıf alanı";
        public void MetotCocuk()
        {
            Console.WriteLine($"Çocuk sınıf MetotCocuk --- alan : {cocukAlan}");
        }
    }
}
