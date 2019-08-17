using SGL.Domain.Entity;
using System;
using System.Linq;

namespace SGL.Application.Interfaces
{
    public interface IAutorAppService : IDisposable
    {
        Autor Adicionar(Autor obj);
        Autor Atualizar(Autor obj);
        IQueryable<Autor> ObterTodos();
        Autor ObterPorId(int id);
        void Remover(int id);
    }
}
