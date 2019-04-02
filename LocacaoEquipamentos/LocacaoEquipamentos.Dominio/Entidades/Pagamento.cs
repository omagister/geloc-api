using System;

namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }
        public int contratoId { get; set; }
        public int formaPagamentoId { get; set; }
        public int NumeroParcela { get; set; }
        public int TotalParcelas { get; set; }
        public DateTime Vencimento { get; set; }
        public Decimal ValorAPagar { get; set; }
        public Decimal ValorPago { get; set; }
        public DateTime? DataPagamento { get; set; }

        public virtual FormaPagamento formaPagamento { get; set; }
        public virtual Contrato contrato { get; set; }
    }
}