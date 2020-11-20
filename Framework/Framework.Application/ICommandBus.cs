using MediatR;

namespace Framework.Application
{
    public interface ICommandBus
    {
        TResponse Dispatch<TRequest, TResponse>(TRequest command) where TRequest : IRequest<TResponse>;
    }
}
