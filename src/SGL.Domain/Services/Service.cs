using SGL.Domain.Interfaces.Repository;
using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGL.Domain.Services
{
    public class Service<P, K> : IService<P, K> where P : class
    {
        private readonly IRepository<P, K> _pRepository;

        public Service(IRepository<P, K> pRepository)
        {
            _pRepository = pRepository;
        }
        public P Adicionar(P obj)
        {
            var r = _pRepository.Adicionar(obj);
            return r;
        }

        public P Atualizar(P obj)
        {
            var r = _pRepository.Atualizar(obj);
            return r;
        }

        public P ObterPorId(K id)
        {
            var result = _pRepository.ObterPorId(id);
            return result;
        }

        public IQueryable<P> ObterTodos()
        {
            var result = _pRepository.ObterTodos();
            return result;
        }

        public void Remover(K id)
        {
            _pRepository.Remover(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
