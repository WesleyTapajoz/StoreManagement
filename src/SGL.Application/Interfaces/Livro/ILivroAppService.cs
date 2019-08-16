using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGL.Application.Interfaces
{
    public interface ILivroAppService : IDisposable
    {

        AdicionarLivroViewModel Adicionar(AdicionarLivroViewModel obj);
        AtualizarLivroViewModel Atualizar(AtualizarLivroViewModel obj);
        IEnumerable<Livro> ObterTodos();
        LivroViewModel ObterPorId(int id);
        void Remover(int id);
    }
}
