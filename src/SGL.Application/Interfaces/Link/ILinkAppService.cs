using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SGL.Application.Interfaces
{
    public interface ILinkAppService : IDisposable
    {
        Link Adicionar(Link obj);
        Link Atualizar(Link obj);
        IQueryable<Link> ObterTodos();
        Link ObterPorId(int id);
        void Remover(int id);
    }
}
