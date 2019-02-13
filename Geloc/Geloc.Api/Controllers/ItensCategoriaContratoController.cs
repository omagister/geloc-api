using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/itenscategoriacontrato")]
    public class ItensCategoriaContratoController : Controller
    {
        private UnidadeDeTrabalho unidade = new UnidadeDeTrabalho();

        // GET api/itenscategoriacontrato
        [HttpGet]
        public IEnumerable<ItemCategoriaContrato> Get()
        {
            return unidade.ItensCategoriaContratoRepositorio.GetAll();
        }

        // GET api/itenscategoriacontrato/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var itemContrato = unidade.ItensCategoriaContratoRepositorio.Find(id);

            if (itemContrato == null)
            {
                return NotFound();
            }

            return new ObjectResult(itemContrato);
        }

        // POST api/itenscategoriacontrato
        [HttpPost]
        public ActionResult Post([FromBody]ItemCategoriaContrato itemContrato)
        {
            if (itemContrato == null)
            {
                return BadRequest();
            }

            unidade.ItensCategoriaContratoRepositorio.Add(itemContrato);

            return Ok(itemContrato);
        }

        // PUT api/itenscategoriacontrato/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ItemCategoriaContrato itemContrato)
        {
            if (itemContrato == null || itemContrato.ItemCategoriaContratoId != id)
            {
                return BadRequest();
            }

            unidade.ItensCategoriaContratoRepositorio.Edit(itemContrato, id);

            return new NoContentResult();
        }

        // DELETE api/contratos/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var itemContrato = unidade.ItensCategoriaContratoRepositorio.Find(id);

            if (itemContrato == null)
            {
                return NotFound();
            }

            unidade.ItensCategoriaContratoRepositorio.Delete(itemContrato, id);

            return new NoContentResult();
        }
    }
}