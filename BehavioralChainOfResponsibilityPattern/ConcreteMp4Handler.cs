using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralChainOfResponsibilityPattern
{
    public class ConcreteMp4Handler : PlayerHandler
    {
        public override void Play(string filePath)
        {
            if (filePath.EndsWith(".mp4"))
            {
                Console.WriteLine($"{filePath} dosyası çalıyor..");
            }
            else
            {
                if (_SonrakiHandler != null)
                {
                    _SonrakiHandler.Play(filePath);
                }
            }
        }
    }
}
