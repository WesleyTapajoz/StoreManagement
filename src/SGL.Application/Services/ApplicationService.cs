using SGL.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Application.Services
{
    public class ApplicationService
    {
        private readonly IUnitOfWork _uow;

        public ApplicationService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public void Commit(/*TipoTransaction tipoTransaction = TipoTransaction.Create*/)
        {
            _uow.Commit(/*tipoTransaction*/);
        }
    }
}
