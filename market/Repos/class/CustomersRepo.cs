using DatabaseContext.Repos;
using market.Models;
using market.Repos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace market.Repos
{
    internal class CustomersRepo : BaseRepo<Customer>, ICustomerRepo
    {
        public CustomersRepo(projectDBContext marketContext) : base(marketContext)
        {
        }
    }
}
