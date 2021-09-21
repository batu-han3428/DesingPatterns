using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Harmony : IMobilApp
    {
        public void Platform()
        {
            Console.WriteLine("Harmony");
        }
    }
}
