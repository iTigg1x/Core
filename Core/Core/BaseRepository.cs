using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class BaseRepository : IBaseRepository<BaseEntity>
    {
        private readonly BaseContext _baseContext;

        public BaseRepository(BaseContext baseContext)
        {
            this._baseContext = baseContext;
        }

        public void Add(BaseEntity entity)
        {
            _baseContext.Add(entity);
        }

        public void AddRange(IEnumerable<BaseEntity> entities)
        {
            _baseContext.AddRange(entities);
        }

        public BaseEntity FindById(int id)
        {
            return _baseContext.Find<BaseEntity>(id);
        }

        public IQueryable<BaseEntity> GetQuery()
        {
            return _baseContext.Set<BaseEntity>();
        }

        public void Remove(BaseEntity entity)
        {
            _baseContext.Remove(entity);
        }

        public void RemoveRange(IEnumerable<BaseEntity> entities)
        {
            _baseContext.RemoveRange(entities);
        }

        public void Update(BaseEntity entity)
        {
            _baseContext.Update(entity);
        }

        public void Update(IEnumerable<BaseEntity> entities)
        {
            _baseContext.UpdateRange(entities);
        }
    }
}