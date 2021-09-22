using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class absUrun
    {
        public string urunAdi { get; set; }
        private decimal _fiyat { get; set; }
        public List<IUye> takipListesi { get; set; }

        public absUrun(string urunAdi, decimal fiyat)
        {
            takipListesi = new List<IUye>();
            _fiyat = fiyat;
            this.urunAdi = urunAdi;
        }

        public decimal Fiyat
        {
            get { return _fiyat; }
            set {
               

                if (value < _fiyat)
                {
                    _fiyat = value;
                    NotifyUrun();
                }
                
            }
        }

        public void NotifyUrun()
        {
            foreach (var item in takipListesi)
            {
                item.update(this);
            }
        }
    }
}
