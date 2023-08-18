using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralTasarimObserver
{
    internal class Uye : IUye
    {
        public string E_Mail { get; set; }
        public void Update(Urun u)
        {
            Console.WriteLine("{0} ın fiyatı {1} oldu ve {2} adresine gönderildi",u.UrunAdi,u.Fiyat.ToString("C2"),E_Mail);

        }
    }
}
