using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/emailsporpessoa")]
    public class EmailsPorPessoaController : Controller
    {
        private RetornaDados retorna = new RetornaDados();

        // POST api/emailsporpessoa/
        [HttpPost("{id}")]
        public IEnumerable<Email> RetornaEmails(int id)
        {
            var emails = retorna.retornaEmailsPorPessoa(id);

            return emails;
        }
    }
}