using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                bir nesnede meydana gelen değişikliklerde içinde bulunduğu listede bulunan nesnelere haber gönderen tasarım desenidir.
            */

            absUrun kitap = new Urun("Kitap", 42.5m);

            Uye ali = new Uye();
           
            ali.Email = "ali@gmail.com";
           
            kitap.takipListesi.Add(ali);
            

            kitap.Fiyat = 60;
        }
    }
}
