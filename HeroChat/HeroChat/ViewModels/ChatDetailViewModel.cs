using HeroChat.Models;
using HeroChat.Services;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System;

namespace HeroChat.ViewModels
{
    class ChatDetailViewModel:BaseViewModel
    {
        //private IChatService _chatService;

        private ObservableCollection<Message> _messages;
        public ObservableCollection<Message> Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }

        private Message _message;
        public Message Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public ChatDetailViewModel()
        {
            //_chatService = DependencyService.Get<IChatService>();
            _message = new Message();

            _messages = new ObservableCollection<Message>();
            //_chatService.Connect();
            //_chatService.OnMessageReceived += _chatService_OnMessageReceived;
        }

        private void _chatService_OnMessageReceived(object sender, Message e)
        {
            _messages.Add(new Message { Text = "User", Time = DateTime.Now });
        }

        #region Send Button Command

        Command sendMessageCommmand;

        public Command SendMessageCommand
        {
            get { return sendMessageCommmand ?? (sendMessageCommmand = new Command(ExecuteSendMessageCommand)); }
        }

        private void ExecuteSendMessageCommand(object obj)
        {
            //_chatService.Send(new Message { Text = "User", Time = DateTime.Now });
            _messages.Add(new Message { Text = "User", Time = DateTime.Now });
        }
        #endregion
    }
}
