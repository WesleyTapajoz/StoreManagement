using AutoMapper;
using SGL.Application.Interfaces;
using SGL.Domain.Interfaces.Services;
using SGL.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.Services
{
    public class AppService<C, R, U, D, P, K> : ApplicationService, IAppService<C, R, U, D>
    {
        private readonly IService<P, C, K> _tService;
        public AppService(IService<P, C, K> tService, IUnitOfWork uow) : base(uow)
        {
            _tService = tService;
        }

        public virtual C Adicionar(C obj)
        {

            //var p = Mapper.Map<C, P>(obj);

            //BeginTransaction();

            //var pReturn = _tService.Adicionar(p);

            //Commit();

            //var ret = Mapper.Map<P, C>(pReturn);

            //return ret;

            throw new NotImplementedException();
        }


        public U Atualizar(U obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<R> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(D id)
        {
            throw new NotImplementedException();
        }
    }
}
