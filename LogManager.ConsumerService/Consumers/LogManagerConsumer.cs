using LogManager.ConsumerService.Commands;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogManager.ConsumerService.Consumers
{
    public class LogManagerConsumer : IConsumer<LogCommand>
    {
        public Task Consume(ConsumeContext<LogCommand> context)
        {
            var message = context.Message;

            Console.WriteLine($"ActionName = {message.ActionName} , ControllerName = {message.ControllerName}");

            return Task.CompletedTask;
        }
    }
}
