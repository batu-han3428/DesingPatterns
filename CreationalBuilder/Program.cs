using System;

namespace CreationalBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            KrediKartiBuilder masterKart = new MasterKartBuilder();
            KrediKartKullan KrediKartKullan = new KrediKartKullan();
           
            KrediKartKullan.KartKullan(masterKart); 
            Console.WriteLine(masterKart.Kart.ToString()); 
       
            masterKart = new VisaKartBuilder();
            KrediKartKullan.KartKullan(masterKart);
            Console.WriteLine(masterKart.Kart.ToString());
           
        }
    }
}
