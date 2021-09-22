using System;

namespace StructerAdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            */

            ITarget target = new CalisanAdaptor();
            FaturaSistemi kullanıcı = new FaturaSistemi(target);
            kullanıcı.CalisanGoster();

        }
    }
}
