using market.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseContext.IRepos
{
    public interface IBaseRepo<Entity> where Entity : class
    {
        public void Add(Entity entity);

        public void Update(Entity entity);

        void Delete(Entity entity);

        IEnumerable<Entity> GetAll();


        Entity GetByID(int id);

        // Get List<Entity> Where Custom Condition
        IEnumerable<Entity> GetAllByCondition(Func<Entity, bool> condition);

    }
}
