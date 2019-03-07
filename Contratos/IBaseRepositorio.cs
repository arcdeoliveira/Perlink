using System.Collections.Generic;

namespace Repositorio.Contratos
{
    public interface IBaseRepositorio<T> where T : class
    {
        //métodos abstratos..
        void Atualizar(T obj);
        void Deletar(T obj);
        void Inserir(T obj);
        List<T> TodosObjetosDaEntidade();
        T ProcurarPorId(int id);
    }
}
