using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Eleman
    {
        public IzinHesap izinHesap;
        public IMaasHesapla maasHesap;

        public Eleman(IzinHesap izinHesap, IMaasHesapla maasHesap)
        {
            this.izinHesap = izinHesap;
            this.maasHesap = maasHesap;
        }
        public int izinHesapla()
        {
            return izinHesap.izinHesapla();
        }
        public int maasHesapla()
        {
            return maasHesap.maasHesapla();
        }
    }
}
