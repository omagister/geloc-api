using System.Collections.Generic;

namespace Geloc.Dados
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        
        void Edit(TEntity entity, int id);

        void Delete(TEntity entity, int id);
        
        IEnumerable<TEntity> GetAll();

        TEntity Find(int id);
    }
}
