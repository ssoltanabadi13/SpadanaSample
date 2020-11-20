using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.Core.GenericDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Interface.Facade.Contract.Categories.Commands;
using Sample.Interface.Facade.Contract.Categories.CommandServices;

namespace Sample.Interface.RestApi.Controllers.Categories
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly ICategoryFacade _categoryFacade;

        public CategoriesController(ICategoryFacade categoryFacade)
        {
            _categoryFacade = categoryFacade;
        }

        [HttpPost]
        public IdResponse Post([FromBody] CreateCategoryCommand command)
        {
            return _categoryFacade.CreateCategory(command);
        }
    }
}