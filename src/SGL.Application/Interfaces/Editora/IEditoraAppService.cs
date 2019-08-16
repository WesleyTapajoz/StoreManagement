using SGL.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGL.Application.Interfaces
{
    public interface IEditoraAppService : IDisposable
    {
        AdicionarEditoraViewModel Adicionar(AdicionarEditoraViewModel obj);
        AtualizarEditoraViewModel Atualizar(AtualizarEditoraViewModel obj);
        IEnumerable<EditoraViewModel> ObterTodos();
        EditoraViewModel ObterPorId(int id);
        void Remover(int id);
    }
}
