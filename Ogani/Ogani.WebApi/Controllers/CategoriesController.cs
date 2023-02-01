using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ogani.Application.Modules.CategoryModule;

namespace Ogani.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        readonly IMediator mediator;
        public CategoriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new CategoryGetAllQuery();

            var result = await mediator.Send(query);

            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost]
        public async Task<IActionResult> Add(CategoryCreateCommand command)
        {
            if (!ModelState.IsValid)
            {
                return Ok(ModelState);
            }

            var result = await mediator.Send(command);

            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

