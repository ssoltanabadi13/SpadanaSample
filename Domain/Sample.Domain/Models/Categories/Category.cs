using System;
using System.Collections.Generic;
using Framework.Core.Events;
using Framework.Domain;
using Sample.Domain.Models.Tags;

namespace Sample.Domain.Models.Categories
{
    public class Category : AggregateRootBase<Guid>
    {
        public string Name { get;private set; }
        //public List<CategoryTagAssign> CategoryTagAssigns { get; set; }
        public List<Tag> CategoryTagAssigns { get; set; }
        public Category(Guid id, IEventPublisher publisher, string name) : base(id, publisher)
        {
            Name = name;
        }


        protected Category() { }
    }
}