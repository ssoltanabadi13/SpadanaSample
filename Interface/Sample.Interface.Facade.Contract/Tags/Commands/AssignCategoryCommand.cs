using System;
using Framework.Core.GenericDto;
using MediatR;

namespace Sample.Interface.Facade.Contract.Tags.Commands
{
    public class AssignCategoryCommand : IRequest<IdResponse>
    {
        public Guid TagId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SubCategoryId { get; set; }
    }
}