using Framework.Core.GenericDto;
using MediatR;

namespace Sample.Interface.Facade.Contract.Categories.Commands
{
    public class CreateCategoryCommand : IRequest<IdResponse>
    {
        public string Name { get; set; }
    }
}