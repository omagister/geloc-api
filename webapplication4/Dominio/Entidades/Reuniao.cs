using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Reuniao
    {
        public Reuniao()
        {
            this.Partes = new List<Parte>();
        }

        public int ReuniaoId { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Parte> Partes { get; set; }
    }
}
