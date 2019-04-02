using System;
using System.Collections.Generic;

namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class Contrato
    {
        public Contrato()
        {
            this.itensContrato = new List<ItemCategoriaContrato>();
        }

        public int ContratoId { get; set; }
        public int Numero { get; set; }
        public int Adicional { get; set; }
        public DateTime? DataSaida { get; set; }
        public DateTime? DataRetorno { get; set; }
        public DateTime? DataPagamento { get; set; }
        public Decimal Valor { get; set; }
        public Decimal Desconto { get; set; }
        public Decimal Acrescimo { get; set; }
        public Decimal ValorAPagar { get; set; }
        public Decimal ValorPago { get; set; }
        public Decimal ValorDeve { get; set; }
        public int Pago { get; set; }
        public string Situacao { get; set; }
        public string Observacao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int EnderecoId { get; set; }
        public int PessoaId { get; set; }
        public string telefonesSelecionados { get; set; }
        public int Renovado { get; set; }
        public string TotalEmMetros { get; set; }
        public DateTime? RetornouEm { get; set; }
        public DateTime? GravadoEm { get; set; }
        public int UsuarioId { get; set; }

        public virtual ICollection<ItemCategoriaContrato> itensContrato { get; set; }
    }
}
