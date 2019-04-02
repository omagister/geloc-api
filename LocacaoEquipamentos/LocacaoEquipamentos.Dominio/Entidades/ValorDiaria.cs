namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class ValorDiaria
    {
        
        public int ValorDiariaId { get; set; }
        public int TabelaValorId { get; set; }
        public decimal Valor { get; set; }

        public virtual TabelaValor tabelaValor { get; set; }
    }
}
