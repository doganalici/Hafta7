using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    class Dikdortgen : ISekil
    {
        public int En { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Boy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AlanHesapla(int en, int boy)
        {
            int alan = en * boy;
            Console.WriteLine($"Dikdörtgenin alanı : {alan}");
        }

        public void CevreHesapla(int en, int boy)
        {
            int cevre = 2*(en + boy);
            Console.WriteLine($"Dikdörtgenin çevresi : {cevre}");
        }
    }
}
