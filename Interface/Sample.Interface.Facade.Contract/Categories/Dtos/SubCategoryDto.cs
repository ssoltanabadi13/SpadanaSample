using System;

namespace Sample.Interface.Facade.Contract.Categories.Dtos
{
    public class SubCategoryDto
    {
        public Guid Id { get;private set; }
        public string Name { get;private set; }

        public SubCategoryDto(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}