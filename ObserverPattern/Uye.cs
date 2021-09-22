using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Uye : IUye
    {
        public string Email { get; set; }
        public void update(absUrun urun)
        {
            Console.WriteLine($"urun: {urun.urunAdi}  ||  Fiyat:{urun.Fiyat}  ||  {Email} adresine bilgi gönderildi.");
        }
    }
}
