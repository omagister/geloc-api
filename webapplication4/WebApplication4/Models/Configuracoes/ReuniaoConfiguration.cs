using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace WebApplication4.Configuracoes
{
    public class ReuniaoConfiguration : EntityTypeConfiguration<Reuniao>
    {
        public ReuniaoConfiguration()
        {
            Property(r => r.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            ToTable("Reunioes");
        }        
    }
}
