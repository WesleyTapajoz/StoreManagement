
using SGL.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGL.Application.Interfaces
{
    public interface IAutorAppService : IDisposable
    {
        AdicionarAutorViewModel Adicionar(AdicionarAutorViewModel obj);
        AtualizarAutorViewModel Atualizar(AtualizarAutorViewModel obj);
        IEnumerable<AutorViewModel> ObterTodos();
        AutorViewModel ObterPorId(int id);
        void Remover(int id);
    }
}
