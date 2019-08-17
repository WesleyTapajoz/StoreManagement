using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGL.Application.Interfaces
{
    public interface IGeneroAppService : IDisposable
    {
        Genero Adicionar(Genero obj);
        Genero Atualizar(Genero obj);
        IQueryable<Genero> ObterTodos();
        Genero ObterPorId(int id);
        void Remover(int id);
    }
}
