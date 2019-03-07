using Entidades.Dominios;
using Repositorio.Mapeamentos;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repositorio.Contexto
{
    public class DataContext : DbContext
    {
        public DataContext() :base(ConfigurationManager.ConnectionStrings["Conexao"]
            .ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new ClienteMapa());
            modelBuilder.Configurations.Add(new ProcessoMapa());
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Processo> Processo { get; set; }
        
    }
}
