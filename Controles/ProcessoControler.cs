using Entidades.Dominios;
using Repositorio.Contratos;
using System;
using System.Globalization;
using System.Linq;

namespace Apresentacao.Controles
{
    public class ProcessoControler
    {
        private readonly IProcessoRepositorio repositorio;

        public ProcessoControler(IProcessoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        #region Case Teste 1
        public void SomaProcessosAtivos()
        {
            Console.WriteLine("\n - Soma de todos processos ativos - \n");

            try
            {                
                var valores = repositorio.TodosObjetosDaEntidade().Where(p => p.Status == true)
                    .Select(p => p.Valor);

                Console.WriteLine("Valor total: " + string.Format(CultureInfo.GetCultureInfo("pt-BR"),
                    "{0:C}", valores.Sum()));
            }
            catch(Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }
        }
        #endregion

        #region Caso de Teste 2
        public void MediaDosValoresDosProcesso()
        {            
            Console.WriteLine("\n - Média dos processos de origem no Rio de Janeiro associado a " +
                "Empresa A - \n");

            try
            {                
                var valores = repositorio.RelacionamentoComCliente().Where(p => p.Local == "Rio de Janeiro" 
                && p.Cliente.Nome.Contains("Empresa A")).Select(p => p.Valor);

                Console.WriteLine("Média: " + string.Format(CultureInfo.GetCultureInfo("pt-BR"),
                    "{0:C}", valores.Sum() / valores.Count()));
            }
            catch(Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }
        }
        #endregion

        #region Caso de Teste 3
        public void NumeroDeProcessosAcimaCemMil()
        {
            Console.WriteLine("\n - Total de Processos com valor maior que 100.000,00 - \n");

            try
            {                
                var valores = repositorio.TodosObjetosDaEntidade().Where(p => p.Valor >  100000m);
                Console.WriteLine("Total de processos: " +  valores.Count().ToString());
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }
        }
        #endregion

        #region Caso de teste 4
        public void ObterListaDeProcessoPorData()
        {
            Console.WriteLine("\n - Nomes de todos processos de Setembro de 2007 - \n");

            try
            {                
                var listaDeSetembro2007 = repositorio.TodosObjetosDaEntidade().Where(p => p.Criacao >=
                new DateTime(2007,9,1) && p.Criacao <= new DateTime(2007, 9, 30));

                foreach(Processo proceso in listaDeSetembro2007)
                {
                    Console.WriteLine("Nome do processo: " + proceso.Nome);
                }                
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }
        }
        #endregion

        #region Caso de Teste 5
        public void ObterListaDeProcessosIgualOrigemDoCliente()
        {
            Console.WriteLine("\n - Nomes dos processos no mesmo estado do cliente, para cada um dos" + 
                "clientes - \n");
            try
            {               
                var listaEmpresaA = repositorio.RelacionamentoComCliente().Where(p => p.Local == 
                "Rio de Janeiro" && p.Cliente.Estado == "Rio de Janeiro");

                Console.WriteLine("Nomes dos processos da Empresa A:");
                foreach (Processo processo in listaEmpresaA)
                {
                    Console.WriteLine(processo.Nome);
                }

                var listaEmpresaB = repositorio.RelacionamentoComCliente().Where(p => p.Local == 
                "São Paulo" && p.Cliente.Estado == "São Paulo");

                Console.WriteLine("\nNomes dos processos da Empresa B:");
                foreach (Processo processo in listaEmpresaB)
                {
                    Console.WriteLine(processo.Nome);
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }
        }
        #endregion

        #region Caso de Teste 6
        public void ObterListaDeProcessosPorSigla()
        {
            Console.WriteLine("\n - Nomes dos processos que contenham a sigla 'TRAB' - \n");
            try
            {                
                var processos = repositorio.TodosObjetosDaEntidade().Where(p => p.Nome.Contains("TRAB"));
                
                foreach (Processo processo in processos)
                {
                    Console.WriteLine("Nome do processo: " + processo.Nome);
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }
        }
        #endregion
    }
}
