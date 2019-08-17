using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGL.Domain.Interfaces.Services
{
    public interface ILivroService : IDisposable
    {
        Livro Adicionar(Livro obj);
        Livro Atualizar(Livro obj);
        IQueryable<Livro> ObterTodos();
        Livro ObterPorId(int id);
        void Remover(int id);
    }
}
