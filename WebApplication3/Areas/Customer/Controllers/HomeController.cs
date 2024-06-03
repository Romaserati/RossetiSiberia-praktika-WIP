using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using RossetiSiberia.Models;
using RossetiSiberia.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;
using RossetiSiberia.Models.ViewModels;

namespace RossetiSiberiaWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Details(int serviceId)
        {

            Service service = _unitOfWork.Service.Get(u => u.Id == serviceId, includeProperties : "Category");

            if (service == null || service.Id == 0)
            {
                return RedirectToAction("Index");
            }

            return View(service);
        }

        public IActionResult Index()
        {
            List<Service> serviceList = _unitOfWork.Service.GetAll(includeProperties: "Category").ToList();


            return View(serviceList);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
