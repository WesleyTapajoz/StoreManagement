using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;
using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SGL.Domain.Services
{
    public class EditoraService : IEditoraService
    {
        private readonly IEditoraRepository _editoraRepository;

        public EditoraService(IEditoraRepository editoraRepository)
        {
            _editoraRepository = editoraRepository;
        }

        public Editora Adicionar(Editora obj)
        {
            return _editoraRepository.Adicionar(obj);
        }

        public Editora Atualizar(Editora obj)
        {
            return _editoraRepository.Atualizar(obj);
        }
         
        public void Dispose()
        {
            _editoraRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Editora ObterPorId(int id)
        {
            return _editoraRepository.ObterPorId(id);
        }

        public IQueryable<Editora> ObterTodos()
        {
            return _editoraRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _editoraRepository.Remover(id);
        }
    }
}
