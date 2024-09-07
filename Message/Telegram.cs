using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message
{
    public class Telegram : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("sending Telegram message");
        }
    }
}
