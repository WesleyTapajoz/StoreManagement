using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SGL.Domain.Interfaces.Services
{
    /// <summary>
    /// Interface genérica IService.
    /// </summary>
    /// <typeparam name="P">Classe POCO (UFMT.SES.Domain.Entity)</typeparam>
    /// <typeparam name="K">Key para Id (string, int, long, etc.)</typeparam>
    public interface IService<P, K> : IDisposable
    {
        P Adicionar(P obj);
        P Atualizar(P obj);
        void Remover(K id);
        IEnumerable<P> ObterTodos();
        P ObterPorId(K id);
    }
}
