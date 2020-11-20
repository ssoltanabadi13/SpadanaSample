using System;
using Framework.Core.Events;

namespace Sample.Domain.Models.Tags
{
    public static class Factory
    {
        public static Tag CreateTag(Guid id, IEventPublisher publisher, string name)
        {
            return new Tag(id,publisher,name);
        }
    }
}