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
        private readonly Contexto _context;

        public ContratosController(Contexto context)
        {
            _context = context;
        }

        // GET api/contratos
        [HttpGet]
        public IEnumerable<Contrato> Get()
        {
            return _context.Contratos;
        }

        // GET api/contratos/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contrato = _context.Contratos.Find(id);

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

            _context.Contratos.Add(contrato);

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

            _context.Contratos.Update(contrato);

            return new NoContentResult();
        }

        // DELETE api/contratos/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contrato = _context.Contratos.Find(id);

            if (contrato == null)
            {
                return NotFound();
            }

            _context.Contratos.Remove(contrato);

            return new NoContentResult();
        }
    }
}