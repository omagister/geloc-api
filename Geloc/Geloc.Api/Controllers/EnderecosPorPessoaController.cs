using Geloc.Dados;
using Geloc.Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Geloc.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/enderecosporpessoa")]
    public class EnderecosPorPessoaController : Controller
    {
        private RetornaDados retorna = new RetornaDados();

        // POST api/enderecosporpessoa/
        [HttpPost("{id}")]
        public IEnumerable<Endereco> RetornaEnderecos(int id)
        {
            var enderecos = retorna.retornaEnderecosPorPessoa(id);
            
            return enderecos;
        }
    }
}