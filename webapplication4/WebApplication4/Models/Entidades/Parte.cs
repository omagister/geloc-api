using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication4.Models.Entidades
{
    public class Parte
    {
        public Parte()
        {
            this.Reuniao = new Reuniao();
        }

        public int ParteId { get; set; }
        public int ReuniaoId { get; set; }
        public int Ordem { get; set; }
        public string Descricao { get; set; }
        public int Ativo { get; set; }

        public Reuniao Reuniao { get; set; }
    }
}
