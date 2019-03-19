using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication4.Models.Entidades
{
    public class Publicador
    {
        

        public int PublicadorId { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Ativo { get; set; }
        public int Dianteira { get; set; }

    }
}
