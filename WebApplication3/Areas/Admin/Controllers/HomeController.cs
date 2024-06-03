using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RossetiSiberia.Utils;

namespace RossetiSiberiaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{SD.Role_Admin}, {SD.Role_Employee}")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
