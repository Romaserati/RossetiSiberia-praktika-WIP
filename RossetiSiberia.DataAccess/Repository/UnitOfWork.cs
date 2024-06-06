using RossetiSiberia.DataAccess.Data;
using RossetiSiberia.DataAccess.Repository.IRepository;
using RossetiSiberia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RossetiSiberia.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext _context;
        public ICategoryRepository Category { get; private set; }

        public IServiceRepository Service { get; private set; }

        public ICustomerRepository Customer { get; private set; }

        public IOrderRepository Order { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Category = new CategoryRepository(context);
            Service = new ServiceRepository(context);
            Customer = new CustomerRepository(context);
            Order = new OrderRepository(context);
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
