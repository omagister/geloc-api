using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace WebApplication4.Configuracoes
{
    public class ParteConfiguration : EntityTypeConfiguration<Parte>
    {
        public ParteConfiguration()
        {
            Property(p => p.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            HasRequired(p => p.Reuniao)
                .WithMany(r => r.Partes)
                .HasForeignKey(p => p.ReuniaoId);

            ToTable("Partes");
        }
    }
}
