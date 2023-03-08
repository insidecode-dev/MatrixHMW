using Autofac;
using Autofac.Core;
using MessageWithAutoFac.Classes;
using MessageWithAutoFac.Interfaces;
using System;

namespace MessageWithAutoFac
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SmsService>().As<IMessageService>();
            builder.RegisterType<MessageSender>();
            var container = builder.Build();
            var myService = container.Resolve<MessageSender>();

            myService.Initialize("mesaj");
        }
    }
}
