using HeroChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroChat.Services
{
    public interface IChatService
    {
        void Connect();
        void Send(Message message);

        event EventHandler<Message> OnMessageReceived;
    }
}
