using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RossetiSiberia.DataAccess.Repository.IRepository;
using RossetiSiberia.Models;
using RossetiSiberia.Utils;

namespace RossetiSiberiaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class UsersController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<RossetiSiberia.Models.Customer> customersList = _unitOfWork.Customer.GetAll();

            return View(customersList);
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<RossetiSiberia.Models.Customer> customerList = _unitOfWork.Customer.GetAll().ToList();
            return Json(new { data = customerList });
        }
        #endregion
    }
}
