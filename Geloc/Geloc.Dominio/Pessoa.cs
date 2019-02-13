using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geloc.Dominio
{
    public class Pessoa
    {
        public Pessoa()
        {
            this.Enderecos = new List<Endereco>();
            this.Telefones = new List<Telefone>();
            this.Emails = new List<Email>();
            
        }
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }
        public DateTime? Nascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Ativo { get; set; }
        public string Observacao { get; set; }
        public string OutrosNoLocal { get; set; }

        [ForeignKey("PessoaId")]
        public virtual ICollection<Endereco> Enderecos { get; set; }
        [ForeignKey("PessoaId")]
        public virtual ICollection<Telefone> Telefones { get; set; }
        [ForeignKey("PessoaId")]
        public virtual ICollection<Email> Emails { get; set; }
        [ForeignKey("PessoaId")]
        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
