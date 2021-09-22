using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class PremiumUser : IUser
    {
        string name;
        IChatMediator chatMediator;
        public PremiumUser(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Kullanıcı Tipi:Premium || Adı:" + name + "|| Alınan Mesaj:" + message);
            Console.WriteLine();
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("--------------Bir mesaj gönderildi..----------------");
            Console.WriteLine("|");
            Console.Write("|");
            Console.WriteLine("          ------Mesajı Gönderen------");
            Console.WriteLine("|");
            Console.WriteLine("|                Gönderen: " + this.name + "\n|               Kullanıcı Tipi: Basic\n|               Mesaj: " + message + "\n");
            chatMediator.SendMessage(message, this);
        }
    }
}
