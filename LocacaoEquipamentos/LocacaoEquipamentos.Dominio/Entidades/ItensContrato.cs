namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class ItensContrato
    {
        public ItensContrato()
        {
            this.Contrato = new Contrato();
            this.Equipamento = new Equipamento();
        }
        public int ItensContratoId { get; set; }
        public int EquipamentoId { get; set; }
        public int ContratoId { get; set; }

        public virtual Contrato Contrato { get; set; }
        public virtual Equipamento Equipamento { get; set; }
    }
}
