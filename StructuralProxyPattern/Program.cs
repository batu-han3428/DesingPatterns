using System;

namespace StructuralProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            */

            string kullanici = "", sifre = "";
            double tutar;


            while (true)
            {
                Console.Write("Lütfen kullanıcı adını giriniz:");
                kullanici = Console.ReadLine();
                Console.Write("Lütfen parola giriniz:");
                sifre = Console.ReadLine();

                Console.Write("Ödenecek miktarı giriniz:");
                tutar = double.Parse(Console.ReadLine());

                IBanka banka = new ProxyBanka(kullanici, sifre);

                banka.OdemeYap(tutar);
            }
        }
    }
}
