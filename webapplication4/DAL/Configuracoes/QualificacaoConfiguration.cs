using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuracoes
{
    public class QualificacaoConfiguration : EntityTypeConfiguration<Qualificacao>
    {
        public QualificacaoConfiguration()
        {
            Property(r => r.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            ToTable("Qualificacoes");
        }
    }
}
