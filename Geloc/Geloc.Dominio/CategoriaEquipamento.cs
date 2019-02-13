using System.Collections.Generic;

namespace Geloc.Dominio
{
    public class CategoriaEquipamento
    {
        public CategoriaEquipamento()
        {
            this.pacotesAluguel = new List<PacoteAluguel>();
        }

        public int CategoriaEquipamentoId { get; set; }
        public string Nome { get; set; }
        public string Abreviacao { get; set; }
        public int QuantidadeTotal { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int QuantidadeLocada { get; set; }

        public virtual ICollection<PacoteAluguel> pacotesAluguel { get; set; }
    }
}
