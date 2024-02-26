using DatabaseContext.IRepos;
using DatabaseContext.Repos;
using market.Models;
//using market.UnitOfWork.Interface;
using DatabaseContext.UnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using market.Repos.Interface;
using market.Repos;

namespace DatabaseContext.UnitOfWork.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly projectDBContext _marketContext;

        public ICustomerRepo CustomerRepository { get; }

        public IOrderRepo OrderRepository { get; }

        public IOrderItemsRepo OrderItemsRepository { get; }

        public IEntryItemsRepo EntryItemsRepository { get; }

        public IProductRepo ProductRepository { get; }

        public IProductEntryRepo ProductEntryRepository { get; }

        public ISupplierRepo SupplierRepository { get; }
        public UnitOfWork(projectDBContext marketContext)
        {
            _marketContext = marketContext;

            CustomerRepository = new CustomersRepo(_marketContext);
            OrderRepository = new OrdersRepo(_marketContext);
            ProductEntryRepository = new ProductEntriesRepo(_marketContext);
            ProductRepository = new ProductsRepo(_marketContext);
            SupplierRepository = new SuppliersRepo(_marketContext);
            EntryItemsRepository = new EntryItemsRepo(_marketContext);
            OrderItemsRepository = new OrderItemsRepo(_marketContext);
        }

        public int SaveChanges()
        {
            return _marketContext.SaveChanges();
        }

        public void Dispose()
        {
            _marketContext.Dispose();
        }
    }
}
