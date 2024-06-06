using RossetiSiberia.DataAccess.Data;
using RossetiSiberia.DataAccess.Repository.IRepository;
using RossetiSiberia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossetiSiberia.DataAccess.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Order order)
        {
            _context.Update(order);
        }
    }
}
