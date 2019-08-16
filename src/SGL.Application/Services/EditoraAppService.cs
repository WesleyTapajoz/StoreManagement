using AutoMapper;
using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;
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
            var editora = Mapper.Map<AdicionarEditoraViewModel, Editora>(obj);

            BeginTransaction();
            var returno = _editoraService.Adicionar(editora);
            Commit();

            return Mapper.Map<Editora, AdicionarEditoraViewModel>(returno);
        }

        public AtualizarEditoraViewModel Atualizar(AtualizarEditoraViewModel obj)
        {
            var editora = Mapper.Map<AtualizarEditoraViewModel, Editora>(obj);

            BeginTransaction();
            var returno = _editoraService.Atualizar(editora);
            Commit();

            return Mapper.Map<Editora, AtualizarEditoraViewModel>(returno);
        }

        public void Dispose()
        {
            _editoraService.Dispose();
            GC.SuppressFinalize(this);
        }

        public EditoraViewModel ObterPorId(int id)
        {
            return Mapper.Map<Editora, EditoraViewModel>(_editoraService.ObterPorId(id));
        }

        public IEnumerable<EditoraViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Editora>, IEnumerable<EditoraViewModel>>(_editoraService.ObterTodos());
        }

        public void Remover(int id)
        {
            _editoraService.Remover(id);
        }
    }
}
