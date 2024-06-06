using Microsoft.AspNetCore.Mvc;
using RossetiSiberia.DataAccess.Repository.IRepository;
using RossetiSiberia.Models;

namespace RossetiSiberiaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public OrdersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Order> order = _unitOfWork.Order.GetAll(includeProperties: "Service,Customer").ToList();

            return View(order);
        }
    }
}
