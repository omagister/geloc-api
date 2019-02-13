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
        private UnidadeDeTrabalho unidade = new UnidadeDeTrabalho();

        [Authorize("Bearer")]
        // GET api/pessoas
        [HttpGet]
        public IEnumerable<Pessoa> Get()
        {
            return unidade.PessoaRepositorio.GetAll();
        }

        [Authorize("Bearer")]
        // GET api/pessoas/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pessoa = unidade.PessoaRepositorio.Find(id);
            
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

            unidade.PessoaRepositorio.Add(pessoa);

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

            unidade.PessoaRepositorio.Edit(pessoa, id);

            return new NoContentResult();
        }

        [Authorize("Bearer")]
        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pessoa = unidade.PessoaRepositorio.Find(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            unidade.PessoaRepositorio.Delete(pessoa, id);

            return new NoContentResult();
        }
    }
}