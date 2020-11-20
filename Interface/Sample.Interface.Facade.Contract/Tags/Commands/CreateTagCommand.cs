using Framework.Core.GenericDto;
using MediatR;

namespace Sample.Interface.Facade.Contract.Tags.Commands
{
    public class CreateTagCommand : IRequest<IdResponse>
    {
        public string Name { get; set; }
    }
}