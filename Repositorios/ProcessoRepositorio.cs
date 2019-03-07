using System.Collections.Generic;
using System.Linq;
using Entidades.Dominios;
using Repositorio.Contexto;
using Repositorio.Contratos;

namespace Repositorio.Repositorios
{
    public class ProcessoRepositorio : BaseRepositorio<Processo>, IProcessoRepositorio
    {
        public List<Processo> RelacionamentoComCliente()
        {
           using(DataContext d = new DataContext())
            {
                return d.Processo.Include("Cliente").ToList();
            }
        }
    }
}
