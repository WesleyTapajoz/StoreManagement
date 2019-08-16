using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGL.Domain.Interfaces.Services
{
    public interface IGeneroService : IDisposable
    {
        Genero Adicionar(Genero obj);
        Genero Atualizar(Genero obj);
        IEnumerable<Genero> ObterTodos();
        Genero ObterPorId(int id);
        void Remover(int id);
    }
}
