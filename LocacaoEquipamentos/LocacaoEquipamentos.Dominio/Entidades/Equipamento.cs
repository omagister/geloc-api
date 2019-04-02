using System;

namespace LocacaoEquipamentos.Dominio.Entidades
{
    public class Equipamento
    {
        public int EquipamentoId { get; set; }
        public string Codigo { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Disponivel { get; set; }
        public string Deposito { get; set; }
        public int ItemCategoriaContratoId { get; set; }
    }
}
