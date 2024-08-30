using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogManager.ConsumerService.Observers
{
    public class ConsumeObserver : IConsumeObserver
    {
        public Task PreConsume<T>(ConsumeContext<T> context) where T : class
        {
            Console.WriteLine("PreConsume");

            return Task.CompletedTask;
        }

        public Task PostConsume<T>(ConsumeContext<T> context) where T : class
        {
            Console.WriteLine("PostConsume");

            return Task.CompletedTask;
        }


        public Task ConsumeFault<T>(ConsumeContext<T> context, Exception exception) where T : class
        {
            Console.WriteLine("ConsumeFault");

            return Task.CompletedTask;
        }

        

    }
}
