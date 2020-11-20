using System;
using System.Collections.Generic;
using Sample.Interface.Facade.Contract.Categories.Dtos;

namespace Sample.Interface.Facade.Contract.Categories.QueryServices
{
    public interface ICategoryQueryFacade
    {
        public List<SubCategoryDto> GetSubCategoriesBy(Guid categoryId);
    }
}