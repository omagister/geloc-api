namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class FormaPagamento
    {
        public int FormaPagamentoId { get; set; }
        public string Descricao { get; set; }
        public int TotalParcelas { get; set; }
        public int DiasEntreParcelas { get; set; }
    }
}