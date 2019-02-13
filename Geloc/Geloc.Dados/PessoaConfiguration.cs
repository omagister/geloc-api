using Geloc.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Geloc.Dados
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            // propriedades
            builder.Property(t => t.Nome)
                .HasColumnType("varchar(max)")
                .IsRequired();

            builder.Property(t => t.Sexo)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(t => t.CNPJ)
                .HasColumnType("varchar(20)");

            builder.Property(t => t.CPF)
                .HasColumnType("varchar(14)");

            
            builder.Property(t => t.Tipo)
                .HasColumnType("varchar(10)")
                .IsRequired();

            
            
            builder.Property(t => t.Ativo)
                .IsRequired();

            
            builder.HasMany(t => t.Enderecos);

            builder.HasMany(t => t.Telefones);

            builder.HasMany(t => t.Emails);

            builder.HasMany(t => t.Contratos);
            
        }
    }
}
