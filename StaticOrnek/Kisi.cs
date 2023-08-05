using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOrnek
{
    public class Kisi
    {
        public static int sayac = 100;
        string ad;
        int yas;
        double maas;

        public Kisi(string ad, int yas, double maas)
        {
            
            this.ad = ad;
            this.yas = yas;
            this.maas = maas;
            sayac++;
        }

        public override string ToString()
        {
            return $"Ad : {ad}\n" +
                   $"Yaş : {yas}\n" +
                   $"Maaş : {maas}\n" +
                   $"Sayaç : {sayac}\n";
        }
    }
}
