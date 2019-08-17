using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGL.Domain.Interfaces.Services
{
    public interface ILinkService : IDisposable
    {

        Link Adicionar(Link obj);
        Link Atualizar(Link obj);
        IQueryable<Link> ObterTodos();
        Link ObterPorId(int id);
        void Remover(int id);
    }
}
