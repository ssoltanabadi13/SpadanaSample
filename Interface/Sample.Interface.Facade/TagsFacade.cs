using Framework.Application;
using Framework.Core.GenericDto;
using Sample.Interface.Facade.Contract.Tags.Commands;
using Sample.Interface.Facade.Contract.Tags.CommandServices;

namespace Sample.Interface.Facade
{
    public class TagsFacade : ITagsFacade
    {
        private readonly ICommandBus _bus;

        public TagsFacade(ICommandBus bus)
        {
            _bus = bus;
        }

        public IdResponse CreateTag(CreateTagCommand command)
        {
            return _bus.Dispatch<CreateTagCommand, IdResponse>(command);
        }

        public IdResponse AssignCategory(AssignCategoryCommand command)
        {
            return _bus.Dispatch<AssignCategoryCommand, IdResponse>(command);
        }
    }
}