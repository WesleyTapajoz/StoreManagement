using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGL.Domain.Interfaces.Services
{
    public interface IService<P, C, K> : IDisposable
    {
        P Adicionar(C obj);
        P Atualizar(P obj);
        void Remover(K id);
        IQueryable<P> ObterTodos();
        P ObterPorId(K id);
    }
}
