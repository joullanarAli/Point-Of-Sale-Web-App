using DatabaseContext.IRepos;
using DatabaseContext.Repos;
using market.Models;
using market.Repos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace market.Repos
{
    internal class ProductsRepo : BaseRepo<Product>, IProductRepo
    {
        public ProductsRepo(projectDBContext marketContext) : base(marketContext)
        {
        }
    }
}
