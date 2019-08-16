using SGL.Domain.Interfaces.Repository;
using SGL.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SGL.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected SGLContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(SGLContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public virtual TEntity Adicionar(TEntity obj)
        {
            var objReturn = DbSet.Add(obj);
            return objReturn;
        }
        public virtual TEntity ObterPorId(int id)
        {
            return DbSet.Find(id); ;
        }
        
        public virtual TEntity Atualizar(TEntity obj)
        {
            try
            {
                if (DbSet.Local.Any())
                {
                    var local = DbSet.Local.Last();
                    if (local != null)
                    {
                        Db.Entry(local).State = EntityState.Detached;
                    }
                    var entry = Db.Entry(obj);
                    entry.State = EntityState.Modified;
                }
                else
                {
                    var entry = Db.Entry(obj);
                    DbSet.Attach(obj);
                    entry.State = EntityState.Modified;
                }

                return obj;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public virtual void Remover(int id)
        {
            DbSet.Remove(ObterPorId(id));
        }
                 
        public virtual void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        IEnumerable<TEntity> IRepository<TEntity>.ObterTodos()
        {
            IQueryable<TEntity> query = DbSet;
            return query;
        }

    }
}
