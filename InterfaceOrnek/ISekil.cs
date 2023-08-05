using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    public interface ISekil
    {
        public int En { get; set; }
        public int Boy { get; set; }
        public void CevreHesapla(int en,int boy);
        public void AlanHesapla(int en, int boy);

    }
}
