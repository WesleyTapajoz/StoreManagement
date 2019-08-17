using AutoMapper;
using SGL.Application.Interfaces;
using SGL.Application.ViewModels;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Services;
using SGL.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Editora Adicionar(Editora obj)
        {
            BeginTransaction();
            var returno = _editoraService.Adicionar(obj);
            Commit();

            return returno;
        }

        public Editora Atualizar(Editora obj)
        {
            BeginTransaction();
            var returno = _editoraService.Atualizar(obj);
            Commit();
            return returno;
        }

        public void Dispose()
        {
            _editoraService.Dispose();
            GC.SuppressFinalize(this);
        }

        public Editora ObterPorId(int id)
        {
            return _editoraService.ObterPorId(id);
        }

        public IQueryable<Editora> ObterTodos()
        {
            return _editoraService.ObterTodos();
        }

        public void Remover(int id)
        {
            BeginTransaction();
            _editoraService.Remover(id);
            Commit();
        }
    }
}
