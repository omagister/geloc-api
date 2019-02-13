using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Geloc.Dados
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        internal Contexto _context;
        internal DbSet<TEntity> _dbSet;

        public RepositorioBase(Contexto context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            
            _context.SaveChanges();
        }

        
        public void Delete(TEntity entity, int id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
            
            _context.SaveChanges();
        }

        

        public void Edit(TEntity entity, int id)
        {
            var entry = _context.Entry<TEntity>(entity);

            if (entry.State == EntityState.Detached)
            {
                var set = _context.Set<TEntity>();
                TEntity attachedEntity = set.Find(id);
                if (attachedEntity != null)
                {
                    var attachedEntry = _context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);
                }
                else
                {
                    entry.State = EntityState.Modified;
                }
            }
            _context.SaveChanges();
        }

        public virtual IEnumerable<TEntity> GetAll() {
            return _context.Set<TEntity>();
        }

        public virtual TEntity Find(int id) {
            return _context.Set<TEntity>().Find(id);
        }

        public void Dispose()
        {
            _dbSet = null;
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
