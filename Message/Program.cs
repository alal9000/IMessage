using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IMessage message;

            //Telegram telegram = new Telegram();
            //SMS sms = new SMS();
            //Email email = new Email();
            //WhatsApp whatsApp = new WhatsApp();

            IMessage message1 = new SMS();
            IMessage message2 = new Email();
            IMessage message3 = new WhatsApp();
            IMessage message4 = new Telegram();

            SendMessage(message4);
        }

        static void SendMessage(IMessage message)
        {
            message.SendMessage();
        }
    }
}
