using System;
using System.Collections.Generic;
using Framework.Core.Events;
using Framework.Domain;
using Sample.Domain.Models.Tags;

namespace Sample.Domain.Models.SubCategories
{
    public class SubCategory : AggregateRootBase<Guid>
    {
        public string Name { get;private set; }
        //public List<CategoryTagAssign> CategoryTagAssigns { get; set; }
        public List<Tag> SubCategoryTagAssigns { get; set; }
        public SubCategory(Guid id, IEventPublisher publisher, string name) : base(id, publisher)
        {
            Name = name;
        }

        protected SubCategory() { }
    }
}