using Geloc.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Geloc.Dados
{
    public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            // propriedades
            builder.Property(t => t.Numero)
                .IsRequired();
            
            builder.Property(t => t.Valor)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(t => t.Desconto)
                .HasColumnType("money");

            builder.Property(t => t.Acrescimo)
                .HasColumnType("money");

            builder.Property(t => t.ValorAPagar)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(t => t.Pago)
                .IsRequired();

            builder.Property(t => t.Situacao)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            builder.Property(t => t.Observacao)
                .HasColumnType("text");
            
            builder.Property(t => t.telefonesSelecionados)
                .HasColumnType("varchar(max)");

            builder.Property(t => t.TotalEmMetros)
                .HasColumnType("varchar(100)");

            builder.Property(t => t.ValorPago)
                .HasColumnType("money");

            builder.Property(t => t.ValorDeve)
                .HasColumnType("money");

            builder.HasMany(t => t.itensContrato);
        }
    }
}
