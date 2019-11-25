using Geloc.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Geloc.Dados
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<ItemCategoriaContrato> ItensCategoriaContrato { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=sql5014.site4now.net;Initial Catalog=DB_A4146E_geloc;User Id=DB_A4146E_geloc_admin;Password=Webdev@34;");
            //options.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=GelocDB;User Id=sa;Password=zaxx34;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new TelefoneConfiguration());
            modelBuilder.ApplyConfiguration(new EmailConfiguration());
            modelBuilder.ApplyConfiguration(new ContratoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemCategoriaContratoConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        
    }
}
