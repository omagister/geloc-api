using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication4.Models.Entidades
{
    public class Designacao
    {
        public Designacao()
        {
            this.Designados = new List<Designado>();
        }

        public int DesignacaoId { get; set; }
        public DateTime data { get; set; }
        public string Parte { get; set; }
        public string Sala { get; set; }
        public DateTime dataCadastro { get; set; }
        public int ordemAdicional { get; set; }

        public virtual ICollection<Designado> Designados { get; set; }
    }
}
