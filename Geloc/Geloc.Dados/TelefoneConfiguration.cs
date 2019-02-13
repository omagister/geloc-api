using Geloc.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Geloc.Dados
{
    public class TelefoneConfiguration : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            //Propriedades
            builder.Property(t => t.Numero)
                .HasColumnType("varchar(max)")
                .IsRequired();

            builder.Property(t => t.TipoTelefone)
                .HasColumnType("varchar(20)");

            builder.Property(t => t.Operadora)
                .HasColumnType("varchar(20)");

            builder.Property(t => t.Ativo)
                .IsRequired();

            builder.Property(t => t.Observacao)
                .HasColumnType("varchar(max)");
        }
    }
}
