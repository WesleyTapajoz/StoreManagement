using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGL.Domain.Interfaces.Services
{
    public interface IEditoraService : IDisposable
    {
        Editora Adicionar(Editora obj);
        Editora Atualizar(Editora obj);
        IEnumerable<Editora> ObterTodos();
        Editora ObterPorId(int id);
        void Remover(int id);
    }
}
