using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/telefonesporpessoa")]
    public class TelefonesPorPessoaController : Controller
    {
        private readonly Contexto _context;

        public TelefonesPorPessoaController(Contexto context)
        {
            _context = context;
        }

        // POST api/enderecosporpessoa/
        [HttpPost("{id}")]
        public IEnumerable<Telefone> RetornaTelefones(int id)
        {
            var telefones = _context.Telefones.Where(t => t.PessoaId == id);

            return telefones;
        }
    }
}