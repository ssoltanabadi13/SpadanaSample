using System.Threading;
using Autofac;
using MediatR;

namespace Framework.Application
{
    public class IocCommandBus : ICommandBus
    {
        private readonly ILifetimeScope _lifetimeScope;

        public IocCommandBus(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public TResponse Dispatch<TRequest, TResponse>(TRequest command) where TRequest : IRequest<TResponse>
        {
            using (var scope = _lifetimeScope.BeginLifetimeScope())
            {
                var handler = scope.Resolve<IRequestHandler<TRequest, TResponse>>();
                 var response = handler.Handle(command,CancellationToken.None).Result;
                 return response;
            }
        }
    }
}
