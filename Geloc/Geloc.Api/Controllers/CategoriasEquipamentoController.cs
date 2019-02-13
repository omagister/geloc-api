using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/categoriasequipamento")]
    public class CategoriasEquipamentoController : Controller
    {
        private UnidadeDeTrabalho unidade = new UnidadeDeTrabalho();

        // GET api/categoriasequipamento
        [HttpGet]
        public IEnumerable<CategoriaEquipamento> Get()
        {
            return unidade.CategoriasEquipamentoRespositorio.GetAll();
        }

        // GET api/categoriasequipamento/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var categoria = unidade.CategoriasEquipamentoRespositorio.Find(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return new ObjectResult(categoria);
        }

        // POST api/categoriasequipamento
        [HttpPost]
        public ActionResult Post([FromBody]CategoriaEquipamento categoria)
        {
            if (categoria == null)
            {
                return BadRequest();
            }

            unidade.CategoriasEquipamentoRespositorio.Add(categoria);

            return Ok(categoria);
        }

        // PUT api/categoriasequipamento/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]CategoriaEquipamento categoria)
        {
            if (categoria == null || categoria.CategoriaEquipamentoId != id)
            {
                return BadRequest();
            }

            unidade.CategoriasEquipamentoRespositorio.Edit(categoria, id);

            return new NoContentResult();
        }

        // DELETE api/categoriasequipamento/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var categoria = unidade.CategoriasEquipamentoRespositorio.Find(id);

            if (categoria == null)
            {
                return NotFound();
            }

            unidade.CategoriasEquipamentoRespositorio.Delete(categoria, id);

            return new NoContentResult();
        }
    }
}