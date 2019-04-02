using System;

namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class HistoricoPagamento
    {
        public int HistoricoPagamentoId { get; set; }
        public int ContratoId { get; set; }
        public DateTime DataPagamento { get; set; }
        public string FormaPagamento { get; set; }
        public Decimal ValorPago { get; set; }
        public Decimal ValorTotalAPagar { get; set; }
        public Decimal ValorDeve { get; set; }
        public string Observacao { get; set; }
    }
}