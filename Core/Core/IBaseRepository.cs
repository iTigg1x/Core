using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(IEnumerable<TEntity> entities);

        IQueryable<TEntity> GetQuery();

        TEntity FindById(int id);

        void Update(TEntity entity);

        void Update(IEnumerable<TEntity> entities);
    }
}
