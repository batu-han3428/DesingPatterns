using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    public class MasterKartBuilder : KrediKartiBuilder
    {

        public MasterKartBuilder()
        {
            kart = new Kredikarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 10000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "MasterKart";
        }

        public override void TaksitAtlatma()
        {
            kart.TaksitAtlatma = true;
        }
    }
}
