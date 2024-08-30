using LogManager.ConsumerService.Commands;
using MassTransit;

namespace LogManager.ConsumerService
{
    public class Worker : BackgroundService
    {
        private readonly IBus _bus;

        public Worker(IBus bus)
        {
            _bus = bus;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                await _bus.Publish(new LogCommand()
                {
                    ActionName = "LogManagerActionName",
                    ControllerName = "LogManagerController"
                }, stoppingToken);

                await Task.Delay(20000, stoppingToken);
            }
        }
    }
}
