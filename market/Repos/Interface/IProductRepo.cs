using DatabaseContext.IRepos;
using market.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace market.Repos.Interface
{
    public interface IProductRepo : IBaseRepo<Product>
    {
    }
}
