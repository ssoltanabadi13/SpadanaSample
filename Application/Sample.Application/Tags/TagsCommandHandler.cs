using System;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;
using Framework.Core.Events;
using Framework.Core.GenericDto;
using MediatR;
using Sample.Domain.Models.Tags;
using Sample.Interface.Facade.Contract.Tags.Commands;

namespace Sample.Application.Tags
{
    public class TagsCommandHandler : IRequestHandler<CreateTagCommand,IdResponse>
        ,IRequestHandler<AssignCategoryCommand, IdResponse>
    {
        private readonly IEventPublisher _eventPublisher;
        private readonly ITagRepository _tagRepository;

        public TagsCommandHandler(IEventPublisher eventPublisher, ITagRepository tagRepository)
        {
            _eventPublisher = eventPublisher;
            _tagRepository = tagRepository;
        }

        public async Task<IdResponse> Handle(CreateTagCommand command, CancellationToken cancellationToken)
        {
            var tag = Factory.CreateTag(Guid.NewGuid(), _eventPublisher, command.Name);
            _tagRepository.Save(tag);
            return new IdResponse(tag.Id);
        }

        public async Task<IdResponse> Handle(AssignCategoryCommand command, CancellationToken cancellationToken)
        {
            var tag = _tagRepository.GetBy(command.TagId);
            tag.AssignCategory(command.CategoryId,command.SubCategoryId);

            return new IdResponse(tag.Id);

        }
    }
}