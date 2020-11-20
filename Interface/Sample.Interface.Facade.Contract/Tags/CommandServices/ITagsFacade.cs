using Framework.Core.GenericDto;
using Sample.Interface.Facade.Contract.Tags.Commands;

namespace Sample.Interface.Facade.Contract.Tags.CommandServices
{
    public interface ITagsFacade
    {
        public IdResponse CreateTag(CreateTagCommand command);
        public IdResponse AssignCategory(AssignCategoryCommand command);
    }
}