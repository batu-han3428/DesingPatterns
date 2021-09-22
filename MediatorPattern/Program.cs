using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            */

            IChatMediator chatMediator = new ChatMediator();

            IUser ali = new BasicUser(chatMediator,"Ali");
            IUser veli = new PremiumUser(chatMediator,"Veli");
            IUser ayşe = new BasicUser(chatMediator,"Ayşe");
            IUser fatma = new PremiumUser(chatMediator,"Fatma");

            chatMediator.AddUser(ali);
            chatMediator.AddUser(veli);
            chatMediator.AddUser(ayşe);
            chatMediator.AddUser(fatma);

            veli.SendMessage("Selam millet");
            ayşe.SendMessage("merhaba");
        }
    }
}
