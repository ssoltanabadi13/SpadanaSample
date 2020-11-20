using System;
using System.Threading;
using System.Threading.Tasks;
using Framework.Core.Events;
using Framework.Core.GenericDto;
using MediatR;
using Sample.Domain.Models.SubCategories;
using Sample.Interface.Facade.Contract.SubCategories;
using Sample.Interface.Facade.Contract.SubCategories.Commands;

namespace Sample.Application.SubCategories
{
    public class SubCategoriesCommandHandler : IRequestHandler<CreateSubCategoryCommand,IdResponse>
    {
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly IEventPublisher _eventPublisher;

        public SubCategoriesCommandHandler(ISubCategoryRepository subCategoryRepository, IEventPublisher eventPublisher)
        {
            _subCategoryRepository = subCategoryRepository;
            _eventPublisher = eventPublisher;
        }

        public async Task<IdResponse> Handle(CreateSubCategoryCommand command, CancellationToken cancellationToken)
        {
            var subCategory = Factory.CreateSubCategory(Guid.NewGuid(), _eventPublisher, command.Name);
            _subCategoryRepository.Save(subCategory);
            return new IdResponse(subCategory.Id);
        }
    }
}