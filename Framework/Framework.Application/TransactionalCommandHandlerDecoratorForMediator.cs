using Framework.Core;
using MediatR;
using System;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Framework.Core.Claims;

namespace Framework.Application
{
    public class TransactionalCommandHandlerDecoratorForMediator<TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : IRequest<TResponse>
    {
        private readonly IRequestHandler<TCommand, TResponse> _commandHandler;
        private readonly IUnitOfWork _unitOfWork;
      
        public TransactionalCommandHandlerDecoratorForMediator(IRequestHandler<TCommand, TResponse> commandHandler, IUnitOfWork unitOfWork)
        {
            _commandHandler = commandHandler;
            _unitOfWork = unitOfWork;
        }
        public async Task<TResponse> Handle(TCommand command, CancellationToken cancellationToken)
        {
            try
            {
                _unitOfWork.Begin();
                var response =await _commandHandler.Handle(command, cancellationToken);
                _unitOfWork.Commit();
                return response;
            }
            catch (Exception ex)
            {
                _unitOfWork.Rollback();
                throw;
            }

        }

      
    }
}
