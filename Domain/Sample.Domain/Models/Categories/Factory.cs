using System;
using Framework.Core.Events;

namespace Sample.Domain.Models.Categories
{
    public static class Factory
    {
        public static Category CreateCategory(Guid id, IEventPublisher eventPublisher, string name)
        {
            return new Category(id,eventPublisher,name);
        }
    }
}