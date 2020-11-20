using System;
using System.Collections.Generic;
using Sample.Domain.Models.Categories;
using Sample.Domain.Models.Tags;
using Sample.Interface.Facade.Contract.Categories.Dtos;
using Sample.Interface.Facade.Contract.Categories.QueryServices;

namespace Sample.Interface.Facade.Query
{
    public class CategoryQueryFacade : ICategoryQueryFacade
    {
        private readonly ITagRepository _tagRepository;

        public CategoryQueryFacade(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public List<SubCategoryDto> GetSubCategoriesBy(Guid categoryId)
        {
            var tags = _tagRepository.GetAllBy(categoryId);
            return Mapper.MapToSubCategoryDto(tags);
        }
    }
}