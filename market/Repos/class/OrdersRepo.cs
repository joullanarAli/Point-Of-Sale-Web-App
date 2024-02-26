using DatabaseContext.Repos;
using market.Models;
using market.Repos.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace market.Repos
{
    internal class OrdersRepo: BaseRepo<Order> , IOrderRepo
    {
        public OrdersRepo(projectDBContext marketContext) : base(marketContext)
        {
        }
        public List<Order> GetAllWithCustomers()
        {
            return _marketContext.Order.Include(e => e.Customer)
                .ToList();
        }
        public List<Order> GetAllWithItems()
        {
            return _marketContext.Order.Include(e => e.OrderItems)
                .ToList();
        }
    }
}
