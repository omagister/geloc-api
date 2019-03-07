using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuracoes
{
    public class DesignacaoConfiguration : EntityTypeConfiguration<Designacao>
    {
        public DesignacaoConfiguration()
        {
            Property(d => d.Sala)
                .HasColumnType("varchar")
                .HasMaxLength(1);

            Property(d => d.Parte)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            ToTable("Designacoes");
        }
    }
}
