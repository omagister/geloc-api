using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/pessoas")]
    public class PessoasController : Controller
    {
        private readonly Contexto _context;

        public PessoasController(Contexto context)
        {
            _context = context;
        }

        [Authorize("Bearer")]
        // GET api/pessoas
        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            return _context.Pessoas;
        }

        [Authorize("Bearer")]
        // GET api/pessoas/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pessoa = _context.Pessoas.Find(id);
            
            if (pessoa == null)
            {
                return NotFound();
            }

            return new ObjectResult(pessoa);
        }

        [Authorize("Bearer")]
        // POST api/pessoas
        [HttpPost]
        public ActionResult Post([FromBody]Pessoa pessoa)
        {
            if (pessoa == null)
            {
                return BadRequest();
            }

            _context.Pessoas.Add(pessoa);

            return Ok(pessoa);
        }

        [Authorize("Bearer")]
        // PUT api/pessoas/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Pessoa pessoa)
        {
            if (pessoa == null || pessoa.PessoaId != id)
            {
                return BadRequest();
            }

            _context.Pessoas.Update(pessoa);

            return new NoContentResult();
        }

        [Authorize("Bearer")]
        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pessoa = _context.Pessoas.Find(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            _context.Pessoas.Remove(pessoa);

            return new NoContentResult();
        }
    }
}