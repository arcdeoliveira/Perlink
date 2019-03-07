using Entidades.Dominios;
using System.Collections.Generic;

namespace Repositorio.Contratos
{
    public interface IProcessoRepositorio : IBaseRepositorio<Processo>
    {
        List<Processo> RelacionamentoComCliente();
    }
}
