using Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Configuracoes
{
    public class PublicadorConfiguration : EntityTypeConfiguration<Publicador>
    {
        public PublicadorConfiguration()
        {
            Property(p => p.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(p => p.Sexo)
                .HasColumnType("varchar")
                .HasMaxLength(1);

            ToTable("Publicadores");
        }
    }
}
