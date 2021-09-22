using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructerAdapterPattern
{
    public class CalisanSistem
    {
       
        public string[][] CalisanlariGetir()
        {
            string[][] calisanlar = new string[4][];

            calisanlar[0] = new string[] {"100","Ali","Muhasebe" };
            calisanlar[1] = new string[] {"101","Veli","Finans" };
            calisanlar[2] = new string[] {"102","Ayşe","IK" };
            calisanlar[3] = new string[] {"103","Fatma","IT" };

            return calisanlar;
        }
    }
}
