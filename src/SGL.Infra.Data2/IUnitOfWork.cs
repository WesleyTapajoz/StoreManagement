using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Infra.Data
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit(/*TipoTransaction tipoTransaction = TipoTransaction.Create*/);
    }
}
