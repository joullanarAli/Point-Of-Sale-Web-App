using DatabaseContext.IRepos;
using market.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace market.Repos.Interface
{
    public interface IOrderRepo : IBaseRepo<Order>
    {
        public List<Order> GetAllWithCustomers();
        public List<Order> GetAllWithItems();
    }
}
