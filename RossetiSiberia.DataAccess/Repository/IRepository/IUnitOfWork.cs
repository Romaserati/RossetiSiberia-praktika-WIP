using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossetiSiberia.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        IServiceRepository Service { get; }
        ICustomerRepository Customer { get; }

        IOrderRepository Order { get; }

        void Save();
    }
}
