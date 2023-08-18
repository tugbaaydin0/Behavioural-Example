using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class YoneticiMaas : IMaasHesapla
    {
        public int maasHesapla()
        {
            return 3500;
        }
    }
}
