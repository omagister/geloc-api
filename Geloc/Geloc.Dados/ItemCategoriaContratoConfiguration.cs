using Geloc.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Geloc.Dados
{
    class ItemCategoriaContratoConfiguration : IEntityTypeConfiguration<ItemCategoriaContrato>
    {
        public void Configure(EntityTypeBuilder<ItemCategoriaContrato> builder)
        {
            // propriedades
            builder.Property(t => t.DescricaoCategoria)
                .HasColumnType("varchar(50)");

            builder.Property(t => t.NomePacote)
                .HasColumnType("varchar(20)");

            builder.Property(t => t.ValorPacote)
                .HasColumnType("money");

            builder.Property(t => t.valorTotal)
                .HasColumnType("money");

            builder.Property(t => t.descontoItem)
                .HasColumnType("money");

            builder.Property(t => t.acrescimoItem)
                .HasColumnType("money");

            builder.Property(t => t.ValorTotalAPagar)
                .HasColumnType("money")
                .IsRequired();
            
            builder.Property(t => t.MedidaPacote)
                .HasColumnType("varchar(10)");
        }
    }
}
