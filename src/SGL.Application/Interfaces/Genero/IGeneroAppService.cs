using SGL.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGL.Application.Interfaces
{
    public interface IGeneroAppService : IDisposable
    {
        AdicionarGeneroViewModel Adicionar(AdicionarGeneroViewModel obj);
        AtualizarGeneroViewModel Atualizar(AtualizarGeneroViewModel obj);
        IEnumerable<GeneroViewModel> ObterTodos();
        GeneroViewModel ObterPorId(int id);
        void Remover(int id);
    }
}
