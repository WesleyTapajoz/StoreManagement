using System;
using System.Collections.Generic;
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
    public interface IAppService<C, R, U, D> : IDisposable
    {
        C Adicionar(C obj);
        IEnumerable<R> ObterTodos();
        U Atualizar(U obj);
        void Remover(D id);
    }
}
