using WebApplication4.Models.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace WebApplication4.Models.Configuracoes 
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            Property(u => u.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            Property(u => u.Senha)
                .HasColumnType("varchar")
                .HasMaxLength(20);

            ToTable("Usuarios");
        }
    }
}