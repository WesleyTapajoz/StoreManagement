using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGL.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        TEntity Adicionar(TEntity obj);
        TEntity Atualizar(TEntity obj);
        void Remover(TKey id);
        TEntity Remover(TEntity obj);
        TEntity ObterPorId(TKey id, ICollection<string> includes = null);
        IQueryable<TEntity> ObterTodos();
    }
}
