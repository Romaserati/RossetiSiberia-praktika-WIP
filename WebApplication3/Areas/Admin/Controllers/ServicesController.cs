using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RossetiSiberia.DataAccess.Data;
using RossetiSiberia.DataAccess.Repository.IRepository;
using RossetiSiberia.Models;
using RossetiSiberia.Models.ViewModels;
using RossetiSiberia.Utils;


namespace RossetiSiberiaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{SD.Role_Admin}, {SD.Role_Employee}")]
    public class ServicesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ServicesController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Service> ServiceList = _unitOfWork.Service.GetAll(includeProperties: "Category").ToList();

            return View(ServiceList);
        }

        /*  public IActionResult Create()
          {
              ServiceVM serviceVM = new()
              {
                  CategoryList = _unitOfWork.Category
                  .GetAll()
                  .Select(u => new SelectListItem
                  {
                      Text = u.CategoryName,
                      Value = u.Id.ToString()
                  }),
                  Service = new Service()
              };

              return View(serviceVM);
          }

          [HttpPost]
          public IActionResult Create(ServiceVM serviceVM)
          {
              if (ModelState.IsValid)
              {
                  TempData["success"] = $"Услуга {serviceVM.Service.Name} успешно создана";
                  _unitOfWork.Service.Add(serviceVM.Service);
                  _unitOfWork.Save();
                  return RedirectToAction("Index");
              }
              else
              {

                  serviceVM.CategoryList = _unitOfWork.Category
                 .GetAll()
                 .Select(u => new SelectListItem
                 {
                     Text = u.CategoryName,
                     Value = u.Id.ToString()
                 });

                  return View(serviceVM);
              }
          }*/

        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult Upsert(int? id)
        {

            ServiceVM serviceVM = new()
            {
                CategoryList = _unitOfWork.Category
                .GetAll()
                .Select(u => new SelectListItem
                {
                    Text = u.CategoryName,
                    Value = u.Id.ToString()
                }),
                Service = new Service()
            };


            if (id == null || id == 0)
            {
                //Создать
                return View(serviceVM);
            }
            else
            {
                //Обновить
                serviceVM.Service = _unitOfWork.Service.Get(u => u.Id == id);
                return View(serviceVM);
            }
        }

        [Authorize(Roles = SD.Role_Admin)]
        [HttpPost]
        public IActionResult Upsert(ServiceVM serviceVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string servicePath = Path.Combine(wwwRootPath, @"Images\Service");

                    if (!string.IsNullOrEmpty(serviceVM.Service.ImageUrl))
                    {
                        var oldImagePath = Path.Combine(wwwRootPath, serviceVM.Service.ImageUrl.TrimStart('\\'));

                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    using (var fileStream = new FileStream(Path.Combine(servicePath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    serviceVM.Service.ImageUrl = @"\Images\Service\" + fileName;
                }

                if (serviceVM.Service.Id == 0)
                {
                    if (serviceVM.Service.ImageUrl == null)
                    {
                        TempData["error"] = "Вы не загрузили картинку";
                    }
                    else
                    {
                        TempData["success"] = $"Услуга {serviceVM.Service.Name} успешно создана";
                        _unitOfWork.Service.Add(serviceVM.Service);
                    }
                }
                else
                {
                    if (serviceVM.Service.ImageUrl == null)
                    {
                        TempData["error"] = "Вы не загрузили картинку";
                    }
                    else
                    {
                        TempData["success"] = $"Услуга {serviceVM.Service.Name} успешно изменена";
                        _unitOfWork.Service.Update(serviceVM.Service);
                    }
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            else
            {

                serviceVM.CategoryList = _unitOfWork.Category
               .GetAll()
               .Select(u => new SelectListItem
               {
                   Text = u.CategoryName,
                   Value = u.Id.ToString()
               });

                return View(serviceVM);
            }
        }

        /*public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Service? serviceFromDb = _unitOfWork.Service.Get(u => u.Id == id);

            if (serviceFromDb == null)
            {
                return NotFound();
            }

            return View(serviceFromDb);
        }*/

        /*[Authorize(Roles = SD.Role_Admin)]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Service? serviceFromDb = _unitOfWork.Service.Get(u => u.Id == id);
            if (serviceFromDb == null)
            {
                return NotFound();
            }

            TempData["success"] = $"Услуга {serviceFromDb.Name} успешно удалена";
            _unitOfWork.Service.Remove(serviceFromDb);
            _unitOfWork.Save();
            return RedirectToAction("Index");

        }*/
        #region API CALLS
        [Authorize(Roles = $"{SD.Role_Admin}, {SD.Role_Employee}")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Service> ServiceList = _unitOfWork.Service.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = ServiceList });
        }

        [Authorize(Roles = SD.Role_Admin)]
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var serviceToBeDeleted = _unitOfWork.Service.Get(u => u.Id == id);
            if (serviceToBeDeleted == null)
            {
                return Json(new { success = false, message = "Ошибка удаления" });
            }

            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, serviceToBeDeleted.ImageUrl.TrimStart('\\'));

            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Service.Remove(serviceToBeDeleted);
            _unitOfWork.Save();

            List<Service> ServiceList = _unitOfWork.Service.GetAll(includeProperties: "Category").ToList();
            return Json(new { success = true, message = $"Услуга \"{serviceToBeDeleted.Name}\" успешно удалена!" });
        }
        #endregion

    }
}
