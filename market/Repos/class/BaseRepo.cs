using DatabaseContext.IRepos;
using market.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseContext.Repos
{
    internal class BaseRepo<Entity> : IBaseRepo<Entity> where Entity : class
    {
        protected readonly projectDBContext _marketContext;
        public BaseRepo (projectDBContext marketContext)
        {
            _marketContext = marketContext;
        }
        void IBaseRepo<Entity>.Add(Entity entity)
        {
            _marketContext.Set<Entity>().Add(entity);
        }

        void IBaseRepo<Entity>.Delete(Entity entity)
        {
            _marketContext.Set<Entity>().Remove(entity);
        }

        Entity IBaseRepo<Entity>.GetByID(int id)
        {
            return _marketContext.Set<Entity>().Find(id);
        }

        IEnumerable<Entity> IBaseRepo<Entity>.GetAll()
        {
            return _marketContext.Set<Entity>().ToList();
        }

        void IBaseRepo<Entity>.Update(Entity entity)
        {
           _marketContext.Set<Entity>().Update(entity); 
        }
        IEnumerable<Entity> IBaseRepo<Entity>.GetAllByCondition(Func<Entity,bool> condition)
        {
            return _marketContext.Set<Entity>().Where(condition);
        }
    }
}
