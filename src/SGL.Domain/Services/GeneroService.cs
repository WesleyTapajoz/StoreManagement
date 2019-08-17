using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;
using System.Linq.Expressions;
using System.Linq;

namespace SGL.Domain.Services
{
    public class GeneroService : IGeneroService
    {
        private readonly IGeneroRepository _generoRepository;

        public GeneroService(IGeneroRepository generoRepository) 
        {
            _generoRepository = generoRepository;
        }

        public Genero Adicionar(Genero obj)
        {
            return _generoRepository.Adicionar(obj);
        }

        public Genero Atualizar(Genero obj)
        {
            return _generoRepository.Atualizar(obj);

        }
 
        public void Dispose()
        {
            _generoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Genero ObterPorId(int id)
        {
            return _generoRepository.ObterPorId(id);
        }

        public IQueryable<Genero> ObterTodos()
        {
            return _generoRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _generoRepository.Remover(id); ;
        }
    }
}
