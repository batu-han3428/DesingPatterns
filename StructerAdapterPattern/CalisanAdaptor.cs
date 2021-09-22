using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructerAdapterPattern
{
    public class CalisanAdaptor : CalisanSistem, ITarget
    {
        public List<string> GetEmployeeList()
        {
            List<string> calisanListesi = new List<string>();

            string[][] employees = CalisanlariGetir();

            foreach (string[] item in employees)
            {
                calisanListesi.Add(item[0]+" "+item[1]+" "+item[2]); 
  
               
            }

            return calisanListesi;
        }
    }
}
