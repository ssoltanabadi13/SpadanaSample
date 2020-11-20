using Framework.Core.GenericDto;
using MediatR;

namespace Sample.Interface.Facade.Contract.SubCategories.Commands
{
    public class CreateSubCategoryCommand : IRequest<IdResponse>
    {
        public string Name { get; set; }
    }
}