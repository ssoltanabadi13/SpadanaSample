using Framework.Application;
using Framework.Core.GenericDto;
using Sample.Interface.Facade.Contract.Categories.Commands;
using Sample.Interface.Facade.Contract.Categories.CommandServices;

namespace Sample.Interface.Facade
{
    public class CategoryFacade : ICategoryFacade
    {
        private readonly ICommandBus _bus;

        public CategoryFacade(ICommandBus bus)
        {
            _bus = bus;
        }

        public IdResponse CreateCategory(CreateCategoryCommand command)
        {
            return _bus.Dispatch<CreateCategoryCommand, IdResponse>(command);
        }
    }
}