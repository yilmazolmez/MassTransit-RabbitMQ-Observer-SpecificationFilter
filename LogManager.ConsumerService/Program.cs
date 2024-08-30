using LogManager.ConsumerService;
using LogManager.ConsumerService.Observers;
using MassTransit;
using System.Reflection;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton<IPublishObserver, PublishObserver>();
builder.Services.AddSingleton<ISendObserver, SendObserver>();


builder.Services.AddSingleton<IConsumeObserver, ConsumeObserver>();

builder.Services.AddMassTransit(x =>
{
    var assembly = Assembly.GetEntryAssembly();

    x.AddConsumers(assembly);

    x.UsingRabbitMq((hostContext, cfg) =>
    {
        cfg.Host("localhost", configurator =>
        {
            configurator.Username("guest");
            configurator.Password("guest");
        });


        #region Publish Observer
        //var serviceProvier = hostContext.GetRequiredService<IServiceProvider>();

        //var publishObservers = serviceProvier.GetServices<IPublishObserver>();

        //foreach (var publishObserver in publishObservers)
        //{
        //    cfg.ConnectPublishObserver(publishObserver);
        //}

     
        //var sendObservers = serviceProvier.GetServices<ISendObserver>();

        //foreach (var sendObserver in sendObservers)
        //{
        //    cfg.ConnectSendObserver(sendObserver);
        //}


        //var consumeObservers = serviceProvier.GetServices<IConsumeObserver>();

        //foreach (var consumeObserver in consumeObservers)
        //{
        //    cfg.ConnectConsumeObserver(consumeObserver);
        //}
        #endregion


        cfg.ConfigureEndpoints(hostContext);
    });
});


builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
