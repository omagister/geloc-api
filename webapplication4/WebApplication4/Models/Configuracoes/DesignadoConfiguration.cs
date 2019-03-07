using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace WebApplication4.Configuracoes
{
    public class DesignadoConfiguration : EntityTypeConfiguration<Designado>
    {
        public DesignadoConfiguration()
        {
            Property(p => p.Qualificacao)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            HasRequired(d => d.Designacao)
                .WithMany(d => d.Designados)
                .HasForeignKey(d => d.DesignacaoId);

            
            ToTable("Designados");
        }
    }
}
