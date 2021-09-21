using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class singleton1
    {
        private static singleton1 _teknesne = new singleton1();

        //dışarıdan erişime kapattık
        private singleton1()
        {

        }

        //_teknesne olarak oluşturulan sınıfın propu
        public static singleton1 Sinif
        {
            get { return _teknesne; }
        }


        //yukarıda ki prop yerine method da yazabiliriz
        public static singleton1 getInstance()
        {
            return _teknesne;
        }
    }
}
