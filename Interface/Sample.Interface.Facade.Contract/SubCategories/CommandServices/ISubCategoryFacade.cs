using Framework.Core.GenericDto;
using Sample.Interface.Facade.Contract.SubCategories.Commands;

namespace Sample.Interface.Facade.Contract.SubCategories.CommandServices
{
    public interface ISubCategoryFacade
    {
        public IdResponse CreateSubCategory(CreateSubCategoryCommand command);
    }
}