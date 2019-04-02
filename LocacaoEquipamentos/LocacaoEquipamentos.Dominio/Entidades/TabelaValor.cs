namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class TabelaValor
    {
        public int TabelaValorId { get; set; }
        public string NomeTabela { get; set; }
        public int MesTabela { get; set; }
        public int AnoTabela { get; set; }
        public string PeriodoTabela { get; set; }
        public int Atual { get; set; }
    }
}
