using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructerAdapterPattern
{
    public class FaturaSistemi
    {
        private ITarget _calisanlar;
        public FaturaSistemi(ITarget calisanlar)
        {
            _calisanlar = calisanlar;
        }
        public void CalisanGoster()
        {
            List<string> calisan = _calisanlar.GetEmployeeList();

            Console.WriteLine("------ Çalışanların Listesi ----------");
            foreach (var item in calisan)
            {
                Console.WriteLine(item);
            }
        }
    }
}
