using DatabaseContext.Repos;
using market.Models;
using market.Repos.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace market.Repos
{
    internal class ProductEntriesRepo : BaseRepo<ProductEntry> , IProductEntryRepo
    {
        public ProductEntriesRepo(projectDBContext marketContext) : base(marketContext)
        {

        }
        public List<ProductEntry> GetAllWithSuppliers()
        {
            return _marketContext.ProductEntry.Include(e => e.Supplier)
                .ToList();
        }
    }
}
