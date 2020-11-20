using System;
using Framework.Core.Events;

namespace Sample.Domain.Models.SubCategories
{
    public static class Factory
    {
        public static SubCategory CreateSubCategory(Guid id, IEventPublisher eventPublisher, string name)
        {
            return new SubCategory(id,eventPublisher,name);
        }
    }
}