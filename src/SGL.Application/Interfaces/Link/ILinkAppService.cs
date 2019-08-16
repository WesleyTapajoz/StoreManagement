using SGL.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGL.Application.Interfaces
{
    public interface ILinkAppService : IDisposable
    {
        AdicionarLinkViewModel Adicionar(AdicionarLinkViewModel obj);
        AtualizarLinkViewModel Atualizar(AtualizarLinkViewModel obj);
        IEnumerable<LinkViewModel> ObterTodos();
        LinkViewModel ObterPorId(int id);
        void Remover(int id);
    }
}
