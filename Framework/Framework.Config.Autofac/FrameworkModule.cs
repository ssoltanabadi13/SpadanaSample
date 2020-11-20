using System.Data.Common;
using System.Data.SqlClient;
using Autofac;
using Framework.Application;
using Framework.Core;
using Framework.Core.Claims;
using Framework.Core.Events;
using Framework.EF;
using MediatR;

namespace Framework.Config.Autofac
{
    public class FrameworkModule : Module
    {
        public string ConnectionString { get; set; }
        public FrameworkModule(string connectionString)
        {
            ConnectionString = connectionString;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGenericDecorator(typeof(TransactionalCommandHandlerDecorator<>), typeof(ICommandHandler<>),
                x=>x.CurrentInstance == null);

            builder.RegisterGenericDecorator(typeof(TransactionalCommandHandlerDecoratorForMediator<,>),
                typeof(IRequestHandler<,>));

            builder.RegisterType<IocCommandBus>().As<ICommandBus>()
                .SingleInstance();

            builder.RegisterType<EFUnitOfWork>().As<IUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SystemClock>().As<IClock>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EventAggregator>().As<IEventPublisher>()
                .SingleInstance();
            
            builder.RegisterType<ClaimHelper>().As<IClaimHelper>()
                .InstancePerLifetimeScope();


        }
    }
}
