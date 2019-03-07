using WebApplication4.Configuracoes;
using Dominio.Entidades;
using System.Data.Entity;

namespace WebApplication4.Contexto
{
    public class ContextoDados : DbContext
    {
        public ContextoDados() :base("Data Source=.\\SQLEXPRESS;Initial Catalog=AssDesDB;User Id=sa;Password=zaxx34;")
        {

        }

        public DbSet<Reuniao> Reunioes { get; set; }
        public DbSet<Parte> Partes { get; set; }
        public DbSet<Qualificacao> Qualificacoes { get; set; }
        public DbSet<Publicador> Publicadores { get; set; }
        public DbSet<Designacao> Designacoes { get; set; }
        public DbSet<Designado> Designados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PublicadorConfiguration());
            modelBuilder.Configurations.Add(new ReuniaoConfiguration());
            modelBuilder.Configurations.Add(new ParteConfiguration());
            modelBuilder.Configurations.Add(new QualificacaoConfiguration());
            modelBuilder.Configurations.Add(new DesignacaoConfiguration());
            modelBuilder.Configurations.Add(new DesignadoConfiguration());
        }
    }
}
