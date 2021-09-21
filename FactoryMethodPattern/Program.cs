using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             aynı arayüzü kullanan nesnelerin üretiminden sorumlu tasarım desenidir.
            */

            Creater creater = new Creater();
            IMobilApp mobilAndroid = creater.FactoryMethod(AllMobileOs.Android);
            IMobilApp mobilIos = creater.FactoryMethod(AllMobileOs.Iphone);
            IMobilApp mobilHarmony = creater.FactoryMethod(AllMobileOs.Harmony);

            mobilAndroid.Platform();
            mobilIos.Platform();
            mobilHarmony.Platform();
        }
    }
}
