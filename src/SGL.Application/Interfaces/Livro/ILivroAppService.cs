using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGL.Application.Interfaces
{
    public interface ILivroAppService : IDisposable
    {

        Livro Adicionar(Livro obj);
        Livro Atualizar(Livro obj);
        IQueryable<Livro> ObterTodos();
        Livro ObterPorId(int id);
        void Remover(int id);
    }
}
