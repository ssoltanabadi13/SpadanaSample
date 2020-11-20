using Framework.Application;
using Framework.Core.GenericDto;
using Sample.Interface.Facade.Contract.SubCategories.Commands;
using Sample.Interface.Facade.Contract.SubCategories.CommandServices;

namespace Sample.Interface.Facade
{
    public class SubCategoryFacade : ISubCategoryFacade
    {
        private readonly ICommandBus _bus;

        public SubCategoryFacade(ICommandBus bus)
        {
            _bus = bus;
        }

        public IdResponse CreateSubCategory(CreateSubCategoryCommand command)
        {
            return _bus.Dispatch<CreateSubCategoryCommand, IdResponse>(command);
        }
    }
}