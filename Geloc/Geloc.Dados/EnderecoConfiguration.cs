using Geloc.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Geloc.Dados
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            //Propriedades

            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar(max)")
                .IsRequired();

            builder.Property(e => e.Bairro)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(e => e.Municipio)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(t => t.Complemento)
                .HasColumnType("varchar(50)");

            builder.Property(t => t.CEP)
                .HasColumnType("varchar(10)");

            builder.Property(t => t.Uf)
                .HasColumnType("varchar(2)")
                .IsRequired();

            builder.Property(t => t.Ativo)
                .IsRequired();

            builder.Property(t => t.Referencia)
                .HasColumnType("varchar(max)");
        }
    }
}
