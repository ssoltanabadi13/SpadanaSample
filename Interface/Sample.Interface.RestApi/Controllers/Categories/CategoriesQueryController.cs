using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Interface.Facade.Contract.Categories.Dtos;
using Sample.Interface.Facade.Contract.Categories.QueryServices;

namespace Sample.Interface.RestApi.Controllers.Categories
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesQueryController : ControllerBase
    {
        private readonly ICategoryQueryFacade _categoryQueryFacade;

        public CategoriesQueryController(ICategoryQueryFacade categoryQueryFacade)
        {
            _categoryQueryFacade = categoryQueryFacade;
        }

        [HttpGet("SubCategories/{categoryId}")]
        public List<SubCategoryDto> Get(Guid categoryId)
        {
            return _categoryQueryFacade.GetSubCategoriesBy(categoryId);
        }
    }
}