using System;
using Framework.Core.Events;
using Framework.Domain;
using Sample.Domain.Models.Categories;
using Sample.Domain.Models.SubCategories;

namespace Sample.Domain.Models.Tags
{
    public class Tag : AggregateRootBase<Guid>
    {
        public string Name { get;private set; }
        public Guid? CategoryId { get; private set; }
        public Category Category { get; set; }
        public Guid? SubCategoryId { get; private set; }
        public SubCategory SubCategory { get; set; }
        public Tag(Guid id, IEventPublisher publisher, string name) : base(id, publisher)
        {
            Name = name;
        }

        protected Tag() { }
        public void AssignCategory(Guid? categoryId, Guid? subCategoryId)
        {
            this.CategoryId = categoryId;
            this.SubCategoryId = subCategoryId;
        }
    }
}