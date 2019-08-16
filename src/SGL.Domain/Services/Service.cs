using SGL.Domain.Interfaces.Repository;
using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SGL.Domain.Services
{
    public class Service//<P, K> : IService<P, K> where P : class
    {
        //private readonly IRepository<P, K> _pRepository;

        //public Service(IRepository<P, K> pRepository)
        //{
        //    _pRepository = pRepository;
        //}

        //public virtual P Adicionar(P obj)
        //{
        //    var r = _pRepository.Adicionar(obj);
        //    return r;
        //}

        //public virtual P Atualizar(P obj)
        //{
        //    var r = _pRepository.Atualizar(obj);
        //    return r;
        //}

        //public virtual P ObterPorId(K id)
        //{
        //    var result = _pRepository.ObterPorId(id);
        //    return result;
        //}

        //public virtual IQueryable<P> ObterTodos()
        //{
        //    var result = _pRepository.ObterTodos();
        //    return result;
        //}

        //public virtual void Remover(K id)
        //{
        //    _pRepository.Remover(id);
        //}

        //public virtual IQueryable<P> Buscar(Expression<Func<P, bool>> predicate)
        //{
        //    var result = _pRepository.Buscar(predicate);
        //}

        //public virtual void Dispose()
        //{
        //    GC.SuppressFinalize(this);
        //}
    }
}
