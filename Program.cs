using Apresentacao.Controles;
using Repositorio.Contratos;
using Repositorio.Repositorios;
using SimpleInjector;
using System;

namespace Apresentacao
{
    static class Program
    {
        static readonly Container container;

        static Program()
        {
            container = new Container();
            container.Register<IProcessoRepositorio, ProcessoRepositorio>();
            container.Register<ProcessoControler>();
            container.Verify();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\n - Sistema de Gerenciamentos de Processo");

            Console.WriteLine("(1) Caso de Teste 1");
            Console.WriteLine("(2) Caso de Teste 2");
            Console.WriteLine("(3) Caso de Teste 3");
            Console.WriteLine("(4) Caso de Teste 4");
            Console.WriteLine("(5) Caso de Teste 5");
            Console.WriteLine("(6) Caso de Teste 6");

            Console.Write("\n Escolha uma opção:");
            int opcao = int.Parse(Console.ReadLine());

            var processoControle = container.GetInstance<ProcessoControler>();

            switch (opcao)
            {
                case 1:
                    processoControle.SomaProcessosAtivos();
                    break;

                case 2:
                    processoControle.MediaDosValoresDosProcesso();
                    break;

                case 3:
                    processoControle.NumeroDeProcessosAcimaCemMil();
                    break;

                case 4:
                    processoControle.ObterListaDeProcessoPorData();
                    break;

                case 5:
                    processoControle.ObterListaDeProcessosIgualOrigemDoCliente();
                    break;

                case 6:
                    processoControle.ObterListaDeProcessosPorSigla();
                    break;

                default:
                    Console.WriteLine("\n Opçao invalida");
                    break;
            }         
            
            Console.ReadKey();
        }
    }
}
