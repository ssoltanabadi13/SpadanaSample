using System.Collections.Generic;
using Sample.Domain.Models.Tags;
using Sample.Interface.Facade.Contract.Categories.Dtos;

namespace Sample.Interface.Facade.Query
{
    public static class Mapper
    {
        public static List<SubCategoryDto> MapToSubCategoryDto(List<Tag> tags)
        {
            var subCategoryDtos = new List<SubCategoryDto>();

            foreach (var tag in tags)
            {
                subCategoryDtos.Add(new SubCategoryDto(tag.SubCategoryId.Value,tag.SubCategory.Name));
            }

            return subCategoryDtos;
        }
    }
}