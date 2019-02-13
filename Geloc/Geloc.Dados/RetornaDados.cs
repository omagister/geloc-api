using System;
using System.Collections.Generic;
using System.Text;
using Geloc.Dominio;
using System.Linq;

namespace Geloc.Dados
{
    public class RetornaDados
    {
        private Contexto db = new Contexto();
        
        public List<Endereco> retornaEnderecosPorPessoa(int idPessoa)
        {
            List<Endereco> enderecos = new List<Endereco>();

            enderecos = db.Enderecos.Where(e => e.PessoaId == idPessoa).ToList();

            return enderecos;
        }

        public List<Telefone> retornaTelefonesPorPessoa(int idPessoa)
        {
            List<Telefone> telefones = new List<Telefone>();

            telefones = db.Telefones.Where(t => t.PessoaId == idPessoa).ToList();

            return telefones;
        }

        public List<Email> retornaEmailsPorPessoa(int idPessoa)
        {
            List<Email> emails = new List<Email>();

            emails = db.Emails.Where(e => e.PessoaId == idPessoa).ToList();

            return emails;
        }
    }
}
