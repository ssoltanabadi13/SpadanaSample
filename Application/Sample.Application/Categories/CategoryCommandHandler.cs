using System;
using System.Threading;
using System.Threading.Tasks;
using Framework.Core.Events;
using Framework.Core.GenericDto;
using MediatR;
using Sample.Domain.Models.Categories;
using Sample.Interface.Facade.Contract.Categories;
using Sample.Interface.Facade.Contract.Categories.Commands;

namespace Sample.Application.Categories
{
    public class CategoryCommandHandler : IRequestHandler<CreateCategoryCommand,IdResponse>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IEventPublisher _eventPublisher;

        public CategoryCommandHandler(ICategoryRepository categoryRepository, IEventPublisher eventPublisher)
        {
            _categoryRepository = categoryRepository;
            _eventPublisher = eventPublisher;
        }

        public async Task<IdResponse> Handle(CreateCategoryCommand command, CancellationToken cancellationToken)
        {
            var category = Factory.CreateCategory(Guid.NewGuid(), _eventPublisher, command.Name);
            _categoryRepository.Save(category);
            return new IdResponse(category.Id);
        }
    }
}