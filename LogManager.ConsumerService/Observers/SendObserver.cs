using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogManager.ConsumerService.Observers
{
    public class SendObserver : ISendObserver
    {
        public Task PreSend<T>(SendContext<T> context) where T : class
        {
            Console.WriteLine("PreSend");

            return Task.CompletedTask;
        }

        public Task PostSend<T>(SendContext<T> context) where T : class
        {
            Console.WriteLine("PostSend");

            return Task.CompletedTask;
        }

        public Task SendFault<T>(SendContext<T> context, Exception exception) where T : class
        {
            Console.WriteLine("SendFault");

            return Task.CompletedTask;
        }
    }
}
