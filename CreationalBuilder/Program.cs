using System;

namespace CreationalBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Zaman içerisinde geliştirdiğimiz uygulamalar son derece karmaşık bir hal alırlar. 
                Uygulamanın çapının ve ihtiyaçlarının artması bir kenara içerisinde yer alan en küçük parçaların bile kullanımları kompleksleşebilir. 
                Bu küçük birimlerin karmaşıklaşmasına etken olarak gösterilebilecek konulardan biriside, nesne üretimleri için kullanılan sınıfların 
                sayılarının artması ve inşa işlemlerinin kompleks olması olarak düşünülebilir. Hal böyle olunca bazı vakalar için standartlaşmış kalıpları 
                kullanmanın genişleyebilirlik ve ölçeklenebilirlik açısından büyük yararı vardır.
            */

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
