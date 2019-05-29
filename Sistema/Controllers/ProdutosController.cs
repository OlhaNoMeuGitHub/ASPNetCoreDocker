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
    public class ProdutosController : Controller
    {

        private IProdutosBusiness _objBusiness;


        public ProdutosController(IProdutosBusiness userBusiness)
        {
            _objBusiness = userBusiness;
        }


        [HttpGet]
        [SwaggerResponse((200), Type = typeof(List<ProdutosVO>))]
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
        [SwaggerResponse((200), Type = typeof(ProdutosVO))]
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


        [HttpPost]
        [SwaggerResponse((201), Type = typeof(ProdutosVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]ProdutosVO obj)
        {
            if (obj == null) return BadRequest();
            return new OkObjectResult(_objBusiness.Create(obj));
        }


        [HttpPut]
        [SwaggerResponse((202), Type = typeof(ProdutosVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]ProdutosVO book)
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
