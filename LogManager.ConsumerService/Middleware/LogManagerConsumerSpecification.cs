using LogManager.ConsumerService.Consumers;
using MassTransit;
using MassTransit.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogManager.ConsumerService.Middleware
{
    public class LogManagerConsumerSpecification : IPipeSpecification<ConsumerConsumeContext<LogManagerConsumer>>
    {
        public void Apply(IPipeBuilder<ConsumerConsumeContext<LogManagerConsumer>> builder)
        {
            builder.AddFilter(new LogManagerConsumerSpecificationFilter());
        }

        public IEnumerable<ValidationResult> Validate()
        {
            // Burada doğrulama yapılabilir
            return Enumerable.Empty<ValidationResult>();
        }
    }


    public class LogManagerConsumerSpecificationFilter : IFilter<ConsumerConsumeContext<LogManagerConsumer>>
    {
        public void Probe(ProbeContext context)
        {
            // Burada filtre hakkında bilgi eklenebilir
            context.CreateFilterScope("LogManagerConsumerSpecificationFilter");
        }

        public async Task Send(ConsumerConsumeContext<LogManagerConsumer> context, IPipe<ConsumerConsumeContext<LogManagerConsumer>> next)
        {
            //Loglama yapılabilinir.
            Console.WriteLine("LogManagerConsumerSpecificationFilter içerisindeyiz");

            await next.Send(context);

            Console.WriteLine("LogManagerConsumerSpecificationFilter Sonu");

        }
    }
}
