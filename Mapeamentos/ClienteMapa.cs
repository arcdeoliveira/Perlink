using Entidades.Dominios;
using System.Data.Entity.ModelConfiguration;

namespace Repositorio.Mapeamentos
{
    public class ClienteMapa : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapa()
        {
            ToTable("Cliente");
            HasKey(c => c.IdCliente);

            Property(cliente => cliente.IdCliente)
                .HasColumnName("IdCliente")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();
            

            Property(cliente => cliente.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)                
                .IsRequired();

            Property(cliente => cliente.Cnpj)
                .HasColumnName("Cnpj")                
                .IsRequired();

            Property(cliente => cliente.Estado)
                .HasColumnName("Estado")
                .HasMaxLength(20)
                .IsRequired();

            HasMany(cliente => cliente.Processos)
                .WithRequired(processo => processo.Cliente)
                .Map(map => map.MapKey("ClienteId"));
        }
    }
}
