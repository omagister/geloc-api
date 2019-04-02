using System;

namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class PacoteAluguel
    {
        public int PacoteAluguelId { get; set; }
        public string Periodo { get; set; }
        public Decimal ValorAluguel { get; set; }
        public int UnidadesPorPacote { get; set; }
        public int categoriaEquipamentoId { get; set; }
        public int QuantidadeMedida { get; set; }
        public string MedidaUtilizada { get; set; }
        public int DiasPacote { get; set; }
    }
}
