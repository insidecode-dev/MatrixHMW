using Autofac;
using MessageWithAutoFac.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageWithAutoFac
{    
    public class MessageSender
    {
        private IMessageService _messageService;
        public MessageSender(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Initialize(string str)
        {
            _messageService.SendMessage(str);
        }
    }
}
