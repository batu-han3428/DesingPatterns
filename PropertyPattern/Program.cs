using System;

namespace PropertyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                
            */

            Game g1 = new Game(1,"Ali","MultiPlayer",true);
            Game g2 = (Game)g1.Clone();

            if (g1.Equals(g2))
            {
                Console.WriteLine("Aynılar");
            }
            else
            {
                g2._GameName = "Veli";
                Console.WriteLine("Hafıza adresleri aynı değil. Yani farklı nesneler");
            }
        }
    }
}
