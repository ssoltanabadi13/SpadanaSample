using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.Core.GenericDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Interface.Facade;
using Sample.Interface.Facade.Contract.SubCategories.Commands;
using Sample.Interface.Facade.Contract.SubCategories.CommandServices;

namespace Sample.Interface.RestApi.Controllers.SubCategories
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriesController : Controller
    {
        private readonly ISubCategoryFacade _subCategoryFacade;

        public SubCategoriesController(ISubCategoryFacade subCategoryFacade)
        {
            _subCategoryFacade = subCategoryFacade;
        }

        [HttpPost]
        public IdResponse Post([FromBody] CreateSubCategoryCommand command)
        {
            return _subCategoryFacade.CreateSubCategory(command);
        }
    }
}