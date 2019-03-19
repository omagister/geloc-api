using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication4.Models.Entidades
{
    public class Designado
    {
        public Designado()
        {
            this.Designacao = new Designacao();
            this.Publicador = new Publicador();
        }

        public int DesignadoId { get; set; }
        public int DesignacaoId { get; set; }
        public int PublicadorId { get; set; }
        public string Qualificacao { get; set; }

        public Designacao Designacao { get; set; }
        public Publicador Publicador { get; set; }
    }
}
