using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;
using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SGL.Domain.Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;

        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public Autor Adicionar(Autor obj)
        {
            return _autorRepository.Adicionar(obj);
        }

        public Autor Atualizar(Autor obj)
        {
            return _autorRepository.Atualizar(obj);
        }

        public void Dispose()
        {
            _autorRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Autor ObterPorId(int id)
        {
            return _autorRepository.ObterPorId(id);
        }

        public IEnumerable<Autor> ObterTodos()
        {
            return _autorRepository.ObterTodos();
        }

        public void Remover(int id)
        {
            _autorRepository.Remover(id);
        }
    }
}
