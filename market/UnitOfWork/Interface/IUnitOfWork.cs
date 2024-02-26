using market.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using DatabaseContext.IRepos;
using market.Repos.Interface;

namespace DatabaseContext.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        ICustomerRepo CustomerRepository { get; }
        IOrderRepo OrderRepository { get; }
        IProductRepo ProductRepository { get; }
        IProductEntryRepo ProductEntryRepository { get; }
        ISupplierRepo SupplierRepository { get; }
        IEntryItemsRepo EntryItemsRepository { get; }
        IOrderItemsRepo OrderItemsRepository { get; }


    }
}
