using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message
{
    public class WhatsApp : IMessage
    {
        public void SendMessage()
        {
            Console.WriteLine("sending WhatsApp message");
        }
    }
}
