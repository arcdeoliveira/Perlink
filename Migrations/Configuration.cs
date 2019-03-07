namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Repositorio.Contexto.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Repositorio.Contexto.DataContext context)
        {
            context.Cliente.AddOrUpdate(
                new Entidades.Dominios.Cliente
                {
                    IdCliente = 1,
                    Nome = "Empresa A",
                    Cnpj = "0000000000001",
                    Estado = "Rio de Janeiro"
                },
                new Entidades.Dominios.Cliente
                {
                    IdCliente = 2,
                    Nome = "Empresa B",
                    Cnpj = "0000000000002",
                    Estado = "São Paulo"
                }
            );

            context.Processo.AddOrUpdate(
                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 1,
                         Nome = "00001CIVELRJ",
                         Status = true,
                         Criacao = Convert.ToDateTime("10/10/2007"),
                         Local = "Rio de Janeiro",
                         Valor = 200000m,
                         Cliente = context.Cliente.Find(1)
                     },

                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 2,
                         Nome = "00002CIVELSP",
                         Status = true,
                         Criacao = Convert.ToDateTime("20/10/2007"),
                         Local = "São Paulo",
                         Valor = 100000m,
                         Cliente = context.Cliente.Find(1)
                     },

                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 3,
                         Nome = "00003TRABMG",
                         Status = false,
                         Criacao = Convert.ToDateTime("30/10/2007"),
                         Local = "Minas Gerais",
                         Valor = 10000m,
                         Cliente = context.Cliente.Find(1)
                     },

                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 4,
                         Nome = "00004CIVELRJ",
                         Status = false,
                         Criacao = Convert.ToDateTime("10/11/2007"),
                         Local = "Rio de Janeiro",
                         Valor = 20000m,
                         Cliente = context.Cliente.Find(1)
                     },

                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 5,
                         Nome = "00005CIVELSP",
                         Status = true,
                         Criacao = Convert.ToDateTime("15/11/2007"),
                         Local = "São Paulo",
                         Valor = 35000m,
                         Cliente = context.Cliente.Find(1)
                     },

                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 6,
                         Nome = "00006CIVELRJ",
                         Status = true,
                         Criacao = Convert.ToDateTime("01/05/2007"),
                         Local = "Rio de Janeiro",
                         Valor = 20000m,
                         Cliente = context.Cliente.Find(2)
                     },

                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 7,
                         Nome = "00007CIVELRJ",
                         Status = true,
                         Criacao = Convert.ToDateTime("02/06/2007"),
                         Local = "Rio de Janeiro",
                         Valor = 700000m,
                         Cliente = context.Cliente.Find(2)
                     },

                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 8,
                         Nome = "00008CIVELSP",
                         Status = false,
                         Criacao = Convert.ToDateTime("03/07/2007"),
                         Local = "São Paulo",
                         Valor = 500m,
                         Cliente = context.Cliente.Find(2)
                     },

                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 9,
                         Nome = "00009CIVELSP",
                         Status = true,
                         Criacao = Convert.ToDateTime("04/08/2007"),
                         Local = "São Paulo",
                         Valor = 32000m,
                         Cliente = context.Cliente.Find(2)
                     },

                     new Entidades.Dominios.Processo
                     {
                         IdProcesso = 10,
                         Nome = "00010TRABAM",
                         Status = false,
                         Criacao = Convert.ToDateTime("05/09/2007"),
                         Local = "Amazonas",
                         Valor = 1000m,
                         Cliente = context.Cliente.Find(2)
                     }
                 );
        }
    }
}
