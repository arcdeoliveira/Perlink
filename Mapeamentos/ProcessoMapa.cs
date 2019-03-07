using Entidades.Dominios;
using System.Data.Entity.ModelConfiguration;

namespace Repositorio.Mapeamentos
{
    public class ProcessoMapa : EntityTypeConfiguration<Processo>
    {
        public ProcessoMapa()
        {
            ToTable("Processo");
            HasKey(processo => processo.IdProcesso);

            Property(processo => processo.IdProcesso)
                .HasColumnName("IdProcesso")
                .IsRequired();

            Property(processo => processo.Nome)
               .HasColumnName("NumeroProcesso")
               .IsRequired();

            Property(processo => processo.Status)
               .HasColumnName("Ativo")
               .IsRequired();

            Property(processo => processo.Criacao)
               .HasColumnName("DataCriacao")
               .IsRequired();

            Property(processo => processo.Local)
               .HasColumnName("Estado")
               .IsRequired();

            Property(processo => processo.Valor)
               .HasColumnName("Valor")
               .HasPrecision(18,2)
               .IsRequired();
        }
    }
}