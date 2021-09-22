using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class BasicUser : IUser
    {
        string name;
        IChatMediator chatMediator;
        public BasicUser(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Kullanıcı Tipi:Basic || Adı:"+name+"|| Alınan Mesaj:"+message);
            Console.WriteLine();
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("--------------Bir mesaj gönderildi..----------------");
            Console.WriteLine("|\n\n------Mesajı Gönderen------");
            Console.WriteLine("|");
            Console.WriteLine("|Gönderen: "+ this.name +"\nKullanıcı Tipi: Basic\nMesaj: "+message+"\n");
            chatMediator.SendMessage(message,this);
        }
    }
}
