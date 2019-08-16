using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
using SGL.Domain.Interfaces.Services;
using SGL.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.Services
{
    public class EditoraAppService : ApplicationService, IEditoraAppService
    {

        private readonly IEditoraService _editoraService;

        public EditoraAppService(IEditoraService editoraService, IUnitOfWork uow)
            : base(uow)
        {
            _editoraService = editoraService;
        }

        public AdicionarEditoraViewModel Adicionar(AdicionarEditoraViewModel obj)
        {
            throw new NotImplementedException();
        }

        public AtualizarEditoraViewModel Atualizar(AtualizarEditoraViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public EditoraViewModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EditoraViewModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
