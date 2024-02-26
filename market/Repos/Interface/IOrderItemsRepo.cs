using DatabaseContext.IRepos;
using market.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace market.Repos.Interface
{
    public interface IOrderItemsRepo : IBaseRepo<OrderItems>
    {
        public List<OrderItems> GetAllWithProducts();
    }
}
