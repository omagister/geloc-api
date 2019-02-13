using Geloc.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Geloc.Dados
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // propriedades
            builder.HasKey(u => u.UserId);
                

            builder.Property(u => u.Name)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(u => u.Password)
                .HasColumnType("varchar(20)")
                .IsRequired();
            
        }
    }
}
