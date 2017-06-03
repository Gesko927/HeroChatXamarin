using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroChat.Models
{
    public class Message
    {
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public string GetMessage {
            get
            { return $"{Text}"; }
        }
    }
}
