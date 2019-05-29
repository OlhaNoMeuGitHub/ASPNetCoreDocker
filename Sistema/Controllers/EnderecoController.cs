using Microsoft.AspNetCore.Mvc;
using Sistema.Business;
using Microsoft.AspNetCore.Authorization;
using Sistema.Data.VO;
using System.Collections.Generic;
using Tapioca.HATEOAS;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger.Annotations;
using System;
namespace Sistema.Controllers
{

    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class EnderecoController : Controller
    {

        private IEnderecoBusiness _objBusiness;


        public EnderecoController(IEnderecoBusiness EnderecoBusiness)
        {
            _objBusiness = EnderecoBusiness;
        }


        [HttpGet]
        [SwaggerResponse((200), Type = typeof(List<EnderecoVO>))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return new OkObjectResult(_objBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [SwaggerResponse((200), Type = typeof(EnderecoVO))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(Guid id)
        {
            var book = _objBusiness.FindById(id);
            if (book == null) return NotFound();
            return new OkObjectResult(book);
        }

        [HttpGet("byUserID/{id}")]
        [SwaggerResponse((200), Type = typeof(EnderecoVO))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetbyUserID(Guid id)
        {
            var obj = _objBusiness.FindByUserId(id);
            if (obj == null) return NotFound();
            return new OkObjectResult(obj);
        }




        [HttpPost]
        [SwaggerResponse((201), Type = typeof(EnderecoVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]EnderecoVO obj)
        {
            if (obj == null) return BadRequest();
            return new OkObjectResult(_objBusiness.Create(obj));
        }


        [HttpPut]
        [SwaggerResponse((202), Type = typeof(EnderecoVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]EnderecoVO book)
        {
            if (book == null) return BadRequest();
            var updatedBook = _objBusiness.Update(book);
            if (updatedBook == null) return BadRequest();
            return new OkObjectResult(updatedBook);
        }


        [HttpDelete("{id}")]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete(Guid id)
        {
            _objBusiness.Delete(id);
            return NoContent();
        }

    }

}
