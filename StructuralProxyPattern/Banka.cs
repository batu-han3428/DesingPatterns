using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralProxyPattern
{
    public class Banka
    {
        public bool Ode(double tutar)
        {
            if (tutar < 100)
            {
                Console.WriteLine("Ödeyeceğiniz tutar en az 100TL olmalıdır. Fark:"+ (100 - tutar));
            }else if (tutar > 100)
            {
                Console.WriteLine("Ödeyeceğiniz tutar 100TL den fazla olamaz. Fark:"+(tutar - 100));
            }
            else
            {
                Console.WriteLine("Ödeme başarılı vaziyette gerçekleştirildi.");
                return true;
            }

            return false;
        }
    }
}
