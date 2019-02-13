using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/telefonesporpessoa")]
    public class TelefonesPorPessoaController : Controller
    {
        private RetornaDados retorna = new RetornaDados();

        // POST api/enderecosporpessoa/
        [HttpPost("{id}")]
        public IEnumerable<Telefone> RetornaTelefones(int id)
        {
            var telefones = retorna.retornaTelefonesPorPessoa(id);

            return telefones;
        }
    }
}