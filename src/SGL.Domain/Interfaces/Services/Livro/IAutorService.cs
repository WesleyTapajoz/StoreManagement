using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGL.Domain.Interfaces.Services
{
    public interface IAutorService : IDisposable
    {
        Autor Adicionar(Autor obj);
        Autor Atualizar(Autor obj);
        IEnumerable<Autor> ObterTodos();
        Autor ObterPorId(int id);
        void Remover(int id);
    }
}
