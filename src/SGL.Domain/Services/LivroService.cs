using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;
using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGL.Domain.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public Livro Adicionar(Livro obj)
        {
            return _livroRepository.Adicionar(obj);
        }

        public Livro Atualizar(Livro obj)
        {
            return _livroRepository.Atualizar(obj);
        }

        public void Dispose()
        {
            _livroRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Livro ObterPorId(int id)
        {
            return _livroRepository.ObterPorId(id);
        }

        public IEnumerable<Livro> ObterTodos()
        {
            return _livroRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _livroRepository.Remover(id);
        }
    }
}
