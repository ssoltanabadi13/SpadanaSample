using Framework.Core.GenericDto;
using Sample.Interface.Facade.Contract.Categories.Commands;

namespace Sample.Interface.Facade.Contract.Categories.CommandServices
{
    public interface ICategoryFacade
    {
        public IdResponse CreateCategory(CreateCategoryCommand command);
    }
}