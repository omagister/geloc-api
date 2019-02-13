using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/enderecos")]
    public class EnderecosController : Controller
    {
        private UnidadeDeTrabalho unidade = new UnidadeDeTrabalho();

        // GET api/enderecos
        [HttpGet]
        public IEnumerable<Endereco> Get()
        {
            return unidade.EnderecoRepositorio.GetAll();
        }

        // GET api/enderecos/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var endereco = unidade.EnderecoRepositorio.Find(id);

            if (endereco == null)
            {
                return NotFound();
            }

            return new ObjectResult(endereco);
        }

        // POST api/enderecos
        [HttpPost]
        public ActionResult Post([FromBody]Endereco endereco)
        {
            if (endereco == null)
            {
                return BadRequest();
            }

            unidade.EnderecoRepositorio.Add(endereco);

            return Ok(endereco);
        }

        // PUT api/enderecos/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Endereco endereco)
        {
            if (endereco == null || endereco.PessoaId != id)
            {
                return BadRequest();
            }

            unidade.EnderecoRepositorio.Edit(endereco, id);

            return new NoContentResult();
        }

        // DELETE api/pessoas/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var endereco = unidade.EnderecoRepositorio.Find(id);

            if (endereco == null)
            {
                return NotFound();
            }

            unidade.EnderecoRepositorio.Delete(endereco, id);

            return new NoContentResult();
        }
    }
}