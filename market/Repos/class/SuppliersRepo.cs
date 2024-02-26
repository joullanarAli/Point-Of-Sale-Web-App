using DatabaseContext.Repos;
using market.Models;
using market.Repos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace market.Repos
{
    internal class SuppliersRepo : BaseRepo<Supplier>, ISupplierRepo
    {
        public SuppliersRepo(projectDBContext marketContext) : base(marketContext)
        {
        }
    }
}
