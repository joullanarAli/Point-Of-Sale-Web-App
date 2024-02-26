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
    internal class EntryItemsRepo : BaseRepo<EntryItems> , IEntryItemsRepo
    {
        public EntryItemsRepo(projectDBContext marketContext) : base(marketContext)
        {
        }
        public List<EntryItems> GetAllWithProducts()
        {
            return _marketContext.EntryItems.Include(e => e.Prod)
                .ToList();
        }
    }
}
