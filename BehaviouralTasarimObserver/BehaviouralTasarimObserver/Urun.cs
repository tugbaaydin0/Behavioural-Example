using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralTasarimObserver
{
    internal abstract class Urun
    {
        public string UrunAdi { get; set; }
        private decimal _Fiyat;

        public List<IUye> TakipList = new List<IUye>();

        public Urun(string UrunAd,decimal UrunFiyat)
        {
            this._Fiyat = UrunFiyat;
            this.UrunAdi=UrunAd;
        }
        public decimal Fiyat
        {
            get { return _Fiyat; }
            set
            {
                if (_Fiyat > value)
                    NotifyUrun();
                _Fiyat = value;
            }
        }
        public void NotifyUrun()
        {
            foreach (IUye item in TakipList)
            {
                item.Update(this);
            }
        }
    }
}
