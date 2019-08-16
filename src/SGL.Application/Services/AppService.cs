using AutoMapper;
using SGL.Application.Interfaces;
using SGL.Domain.Interfaces.Services;
using SGL.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGL.Application.Services
{
    public class AppService//<C, R, U, D, P, K> : ApplicationService, IAppService<C, R, U, D, K>
    {
        //private readonly IService<P, K> _tService;
        //public AppService(IService<P, K> tService, IUnitOfWork uow) : base(uow)
        //{
        //    _tService = tService;
        //}

        //public C Adicionar(C obj)
        //{
        //    var p = Mapper.Map(obj, C);
           

        //    throw new NotImplementedException();
        //}

        //public U Atualizar(U obj)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<R> Buscar(Expression<Func<R, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        //public TReturn ObterPorId<TReturn>(K id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<R> ObterTodos()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remover(D id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
