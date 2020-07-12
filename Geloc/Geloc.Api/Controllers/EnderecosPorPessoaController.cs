using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/enderecosporpessoa")]
    public class EnderecosPorPessoaController : Controller
    {
        private readonly Contexto _context;

       public EnderecosPorPessoaController(Contexto context)
       {
           _context = context;
       }

        // POST api/enderecosporpessoa/
        [HttpPost("{id}")]
        public IEnumerable<Endereco> RetornaEnderecos(int id)
        {
            var enderecos = _context.Enderecos.Where(e => e.PessoaId == id).ToList();
            
            return enderecos;
        }
    }
}