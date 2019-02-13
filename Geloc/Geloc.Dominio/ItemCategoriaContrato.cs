using System;

namespace Geloc.Dominio
{
    public class ItemCategoriaContrato
    {
        public int ItemCategoriaContratoId { get; set; }
        public int CategoriaEquipamentoId { get; set; }
        public int PacoteAluguelId { get; set; }
        public int ContratoId { get; set; }
        public int UnidadesPorPacote { get; set; }
        public int QuantidadePacotes { get; set; }
        public string MedidaPacote { get; set; }
        public int quantidadeAlugada { get; set; }
        public Decimal valorTotal { get; set; }
        public Decimal descontoItem { get; set; }
        public Decimal acrescimoItem { get; set; }
        public Decimal ValorTotalAPagar { get; set; }
        public string DescricaoCategoria { get; set; }
        public string NomePacote { get; set; }
        public Decimal ValorPacote { get; set; }
        public DateTime? DataSaida { get; set; }
        public DateTime? DataRetorno { get; set; }
        public DateTime? RetornouEm { get; set; }
        public int EnderecoId { get; set; }
    }
}
