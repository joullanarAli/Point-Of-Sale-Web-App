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
    internal class OrderItemsRepo : BaseRepo<OrderItems>, IOrderItemsRepo
    {
        public OrderItemsRepo(projectDBContext marketContext) : base(marketContext)
        {
        }
        public List<OrderItems> GetAllWithProducts()
        {
            return _marketContext.OrderItems.Include(e => e.Prod)
                .ToList();
        }
    }
}
