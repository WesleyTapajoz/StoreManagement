using SGL.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SGLContext _context;
        private bool _disposed;

        public UnitOfWork(SGLContext context)
        {
            _context = context;
            _disposed = false;
        }

        public void BeginTransaction()
        {
            _disposed = false;
        }

        /// <summary>
        /// Parametro defult é Create, caso for delete passa parametro para que o usuário receba a mensagem de alerta correta, caso não queira exibir mensagem parametro None
        /// </summary>
        /// <param name="tipoTransaction"></param>
        public void Commit(/*TipoTransaction tipoTransaction = TipoTransaction.Create*/)
        {

            try
            {
                _context.SaveChanges();
                //if (tipoTransaction != TipoTransaction.None)
                //    MensagemCustom.AddSucessoMessage(tipoTransaction == TipoTransaction.Delete ? MensagemPadrao.Removido : MensagemPadrao.SalvoComSucesso);
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                //MensagemCustom.AddErroMessage(raise);
                throw raise;

            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

