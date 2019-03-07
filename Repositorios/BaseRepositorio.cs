using System.Collections.Generic;
using System.Linq;
using Repositorio.Contexto;
using Repositorio.Contratos;

namespace Repositorio.Repositorios
{
    public abstract class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        public void Atualizar(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Inserir(T obj)
        {
            throw new System.NotImplementedException();
        }

        public T ProcurarPorId(int id)
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<T>().Find(id);
            }
        }

        public List<T> TodosObjetosDaEntidade()
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<T>().ToList();
            }
        }
    }
}
