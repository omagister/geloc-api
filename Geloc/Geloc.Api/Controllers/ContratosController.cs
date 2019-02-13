using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/contratos")]
    public class ContratosController : Controller
    {
        private UnidadeDeTrabalho unidade = new UnidadeDeTrabalho();

        // GET api/contratos
        [HttpGet]
        public IEnumerable<Contrato> Get()
        {
            return unidade.ContratoRepositorio.GetAll();
        }

        // GET api/contratos/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contrato = unidade.ContratoRepositorio.Find(id);

            if (contrato == null)
            {
                return NotFound();
            }

            return new ObjectResult(contrato);
        }

        // POST api/contratos
        [HttpPost]
        public ActionResult Post([FromBody]Contrato contrato)
        {
            if (contrato == null)
            {
                return BadRequest();
            }

            unidade.ContratoRepositorio.Add(contrato);

            return Ok(contrato);
        }

        // PUT api/contratos/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Contrato contrato)
        {
            if (contrato == null || contrato.ContratoId != id)
            {
                return BadRequest();
            }

            unidade.ContratoRepositorio.Edit(contrato, id);

            return new NoContentResult();
        }

        // DELETE api/contratos/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contrato = unidade.ContratoRepositorio.Find(id);

            if (contrato == null)
            {
                return NotFound();
            }

            unidade.ContratoRepositorio.Delete(contrato, id);

            return new NoContentResult();
        }
    }
}