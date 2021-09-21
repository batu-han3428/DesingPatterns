using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    public class VisaKartBuilder : KrediKartiBuilder
    {

        public VisaKartBuilder()
        {
            kart = new Kredikarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "İş Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 5000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Visa";
        }

        public override void TaksitAtlatma()
        {
            kart.TaksitAtlatma = false;
        }
    }
}
