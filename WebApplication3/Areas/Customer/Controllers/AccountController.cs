using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RossetiSiberia.DataAccess.Repository.IRepository;

namespace RossetiSiberiaWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(RossetiSiberia.Models.Customer customer)
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RossetiSiberia.Models.Customer customer)
        {
            _unitOfWork.Customer.Add(customer);
            _unitOfWork.Save();
            TempData["success"] = $"{customer.FirstName} {customer.MiddleName}, спасибо за регистрацию!";
            return RedirectToAction("Index");
        }

        /*public IActionResult Index(int Id)
        {
            RossetiSiberia.Models.Customer customer = _unitOfWork.Customer.Get(u => u.Id == Id);

            return View(customer);
        }*/
    }
}
