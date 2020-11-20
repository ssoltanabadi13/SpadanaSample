using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework.Core.GenericDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Interface.Facade.Contract.Tags.Commands;
using Sample.Interface.Facade.Contract.Tags.CommandServices;

namespace Sample.Interface.RestApi.Controllers.Tags
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : Controller
    {
        private readonly ITagsFacade _tagsFacade;

        public TagsController(ITagsFacade tagsFacade)
        {
            _tagsFacade = tagsFacade;
        }

        [HttpPost]
        public IdResponse Post([FromBody] CreateTagCommand command)
        {
            return _tagsFacade.CreateTag(command);
        }

        [HttpPut]
        public IdResponse Put([FromBody] AssignCategoryCommand command)
        {
            return _tagsFacade.AssignCategory(command);
        }
    }
}