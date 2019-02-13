using Geloc.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Geloc.Dados
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            // propriedades
            builder.Property(t => t.endereco)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(t => t.Ativo)
                .IsRequired();
        }
    }
}
