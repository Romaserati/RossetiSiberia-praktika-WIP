using RossetiSiberia.DataAccess.Data;
using RossetiSiberia.DataAccess.Repository.IRepository;
using RossetiSiberia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RossetiSiberia.DataAccess.Repository
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        public ApplicationDbContext _context;
        public ServiceRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Service service)
        {
            var objFromDb = _context.Services.FirstOrDefault(u => u.Id == service.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = service.Name;
                objFromDb.Description = service.Description;
                objFromDb.CategoryId = service.CategoryId;

                if (service.ImageUrl != null)
                {
                    objFromDb.ImageUrl = service.ImageUrl;
                }
            }
        }
    }
}
