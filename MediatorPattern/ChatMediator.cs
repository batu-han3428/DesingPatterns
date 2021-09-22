using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ChatMediator : IChatMediator
    {
        List<IUser> users;
        public ChatMediator()
        {
            users = new List<IUser>();
        }
        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            Console.WriteLine("|\n|\n------Mesajı Alanlar------\n");
            foreach (var item in users)
            {
                if (item != sender)
                {
                    item.ReceiveMessage(message);
                }
            }
        }
    }
}
