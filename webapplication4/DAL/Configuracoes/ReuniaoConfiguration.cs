using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuracoes
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
