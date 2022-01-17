using SignalRChat.Models;
using System.Collections.Generic;

namespace SignalRChat.ViewModel
{
    public class VmChat
    {
        public CustomUser Reciever { get; set; }
        public List<Message> Messages { get; set; }
    }
}
