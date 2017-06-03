using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroChat.Models;

namespace HeroChat.Services
{
    class ChatService : IChatService
    {
        //TCP Client дописати
        public event EventHandler<Message> OnMessageReceived;

        public ChatService()
        {

        }

        public void Connect()
        {

        }

        public void Send(Message message)
        {

        }
    }
}
