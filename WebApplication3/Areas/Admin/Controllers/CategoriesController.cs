using Microsoft.AspNetCore.Mvc;
using RossetiSiberia.Models;
using Microsoft.EntityFrameworkCore;
using RossetiSiberia.DataAccess.Data;
using RossetiSiberia.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using RossetiSiberia.Utils;

namespace RossetiSiberiaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = $"{SD.Role_Admin}, {SD.Role_Employee}")]
    public class CategoriesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();

            return View(objCategoryList);
        }

        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = SD.Role_Admin)]
        [HttpPost]
        public IActionResult Create(Category category)
        {

            if (ModelState.IsValid)
            {
                TempData["success"] = $"Категория {category.CategoryName} успешно создана";
                _unitOfWork.Category.Add(category);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [Authorize(Roles = SD.Role_Admin)]
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                TempData["success"] = $"Категория {category.CategoryName} успешно изменена";
                _unitOfWork.Category.Update(category);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [Authorize(Roles = SD.Role_Admin)]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? category = _unitOfWork.Category.Get(u => u.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            TempData["success"] = $"Категория {category.CategoryName} успешно удалена";
            _unitOfWork.Category.Remove(category);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
