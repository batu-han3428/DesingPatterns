using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralChainOfResponsibilityPattern
{
    public class ConcreteAviHandler : PlayerHandler
    {
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".avi"))
            {
                Console.WriteLine($"{filePath} dosyası çalıyor..");
            }
            else
            {
                Console.WriteLine("Geçersiz Dosya Formatı");
            }
        }
    }
}
