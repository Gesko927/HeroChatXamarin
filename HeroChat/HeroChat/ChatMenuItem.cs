using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroChat
{

    public class ChatMenuItem
    {
        public ChatMenuItem()
        {
            TargetType = typeof(ChatDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}