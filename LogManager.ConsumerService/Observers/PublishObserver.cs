using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogManager.ConsumerService.Observers
{
    public class PublishObserver : IPublishObserver
    {
        public Task PrePublish<T>(PublishContext<T> context) where T : class
        {
            context.Headers.Set("x-trace-id","TraceId123123");
            //Yapılacak birçok işlemi burada yapabilirsiniz.

            Console.WriteLine("PrePublish");

            return Task.CompletedTask;
        }


        public Task PostPublish<T>(PublishContext<T> context) where T : class
        {
            //Log atabilirsiniz

            Console.WriteLine("PostPublish");

            return Task.CompletedTask;
        }

       
        public Task PublishFault<T>(PublishContext<T> context, Exception exception) where T : class
        {
            return Task.CompletedTask;
        }
    }
}
