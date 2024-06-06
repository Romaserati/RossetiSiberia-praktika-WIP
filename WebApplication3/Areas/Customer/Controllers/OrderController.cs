using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using RossetiSiberia.DataAccess.Repository.IRepository;
using RossetiSiberia.Models;
using System.Reflection.Metadata.Ecma335;

namespace RossetiSiberiaWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region API CALLS
        [HttpPost]
        public IActionResult Create(int serviceId)
        {
            if (User.Identity.IsAuthenticated)
            {
                Order order = new Order
                {
                    CustomerId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                    ServiceId = serviceId,
                    CreatedOn = DateTime.Now,
                };

                _unitOfWork.Order.Add(order);
                _unitOfWork.Save();

                return Json(new { success = true, message = "Заказ успешно создан" });
            }
            
            return Json(new { success = false, message = "Вы не авторизованы" });
        }
        #endregion
    }
}
