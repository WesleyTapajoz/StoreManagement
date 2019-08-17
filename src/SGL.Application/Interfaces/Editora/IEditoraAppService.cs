using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGL.Application.Interfaces
{
    public interface IEditoraAppService : IDisposable
    {
        Editora Adicionar(Editora obj);
        Editora Atualizar(Editora obj);
        IQueryable<Editora> ObterTodos();
        Editora ObterPorId(int id);
        void Remover(int id);
    }
}
