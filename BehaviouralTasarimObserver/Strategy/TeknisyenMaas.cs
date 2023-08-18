using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class TeknisyenMaas : IMaasHesapla
    {
        public int maasHesapla()
        {
            return 1500;
        }
    }
}
