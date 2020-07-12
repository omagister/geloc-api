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
        private readonly Contexto _context;

        public ItensCategoriaContratoController(Contexto context)
        {
            _context = context;
        }

        // GET api/itenscategoriacontrato
        [HttpGet]
        public IEnumerable<ItemCategoriaContrato> Get()
        {
            return _context.ItensCategoriaContrato;
        }

        // GET api/itenscategoriacontrato/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var itemContrato = _context.ItensCategoriaContrato.Find(id);

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

            _context.ItensCategoriaContrato.Add(itemContrato);

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

            _context.ItensCategoriaContrato.Update(itemContrato);

            return new NoContentResult();
        }

        // DELETE api/contratos/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var itemContrato = _context.ItensCategoriaContrato.Find(id);

            if (itemContrato == null)
            {
                return NotFound();
            }

            _context.ItensCategoriaContrato.Remove(itemContrato);

            return new NoContentResult();
        }
    }
}