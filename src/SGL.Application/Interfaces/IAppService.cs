using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGL.Application.Interfaces
{
    /// <summary>
    /// Interface genérica AppService.
    /// </summary>
    /// <typeparam name="C">ViewModel de Create (AdicionaViewModel)</typeparam>
    /// <typeparam name="R">ViewModel de Retrieve (ListaViewModel)</typeparam>
    /// <typeparam name="U">ViewModel de Update (AtualizaViewModel)</typeparam>
    /// <typeparam name="D">ViewModel de Update (DeletarViewModel)</typeparam>
    /// 
    public interface IAppService<C, R, U, D, K> : IDisposable
    {
        C Adicionar(C obj);
        IEnumerable<R> ObterTodos();
        U Atualizar(U obj);
        TReturn ObterPorId<TReturn>(K id);
        void Remover(D id);
    }
}
