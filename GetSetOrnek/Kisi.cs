using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetOrnek
{
    class Kisi
    {
        //FIELD
        private string ad;
        private int yas;
        private double maas;
        //PROPERTY
        public double Maas { get; set; }
        public char Cinsiyet { get; set; }
        public string Ad
        {
            get { return ad.ToUpper(); }
            set { ad = value; }
        }

        public int Yas 
        {
            get { return yas; }
            set
            {
                if (value<0)
                {
                    value = 0;
                }
                else
                {
                    yas = value;
                }
            }
            
        }
    }
}
