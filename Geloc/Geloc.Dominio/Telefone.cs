﻿namespace Geloc.Dominio
{
    public class Telefone
    {
        public int TelefoneId { get; set; }
        public string TipoTelefone { get; set; }
        public string Operadora { get; set; }
        public string Numero { get; set; }
        public int Ativo { get; set; }
        public int PessoaId { get; set; }
        public string Observacao { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }

    
}
