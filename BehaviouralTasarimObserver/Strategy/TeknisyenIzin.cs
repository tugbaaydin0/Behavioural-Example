using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class TeknisyenIzin : IzinHesap
    {
        public int izinHesapla()
        {
            return 10;
        }
    }
}
