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
    public class PedidosController : Controller
    {

        private IPedidosBusiness _objBusiness;
        private IPontosBusiness _PontosBusiness;
        private IUserDadosBusiness _UserDadosBusiness;

        public PedidosController(IPedidosBusiness PedidosBusiness
            , IPontosBusiness PontosBusiness, IUserDadosBusiness UserDadosBusiness
            )
        {
            _objBusiness = PedidosBusiness;
            _PontosBusiness = PontosBusiness;
            _UserDadosBusiness = UserDadosBusiness;
        }


        [HttpGet]
        [SwaggerResponse((200), Type = typeof(List<PedidosVO>))]
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
        [SwaggerResponse((200), Type = typeof(PedidosVO))]
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
        [SwaggerResponse((200), Type = typeof(PedidosVO))]
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
        [SwaggerResponse((201), Type = typeof(PedidosVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]PedidosVO obj)
        {
            if (obj == null) return BadRequest();
            PontosVO pontos = new PontosVO
            {
                Valor = obj.Valor,
                Descricao = obj.Descricao,
                Data = obj.Data,
                UserId = obj.UserId
            };
            _PontosBusiness.Create(pontos);
            var user = _UserDadosBusiness.FindById(obj.UserId);
            user.Pontos = user.Pontos + obj.Valor;
            _UserDadosBusiness.Update(user);

            return new OkObjectResult(_objBusiness.Create(obj));
        }


        [HttpPut]
        [SwaggerResponse((202), Type = typeof(PedidosVO))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [Authorize("Bearer")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]PedidosVO obj)
        {
            if (obj == null) return BadRequest();
            var updatedobj = _objBusiness.Update(obj);
            if (updatedobj == null) return BadRequest();
            return new OkObjectResult(updatedobj);
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
