using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/emailsporpessoa")]
    public class EmailsPorPessoaController : Controller
    {
        private readonly Contexto _context;

        public EmailsPorPessoaController(Contexto context)
        {
            _context = context;
        }

        // POST api/emailsporpessoa/
        [HttpPost("{id}")]
        public IEnumerable<Email> RetornaEmails(int id)
        {
            var emails = _context.Emails.Where(e => e.PessoaId == id).ToList();

            return emails;
        }
    }
}