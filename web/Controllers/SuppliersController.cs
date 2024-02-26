using DatabaseContext.UnitOfWork.Interface;
using market.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace web.Controllers
{
    public class SuppliersController : BaseController
    {
        public SuppliersController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetSuppliers()
        {
            var suppliers = _unitOfWork.SupplierRepository.GetAll();
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = suppliers
            });
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(market.Models.Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.SupplierRepository.Add(supplier);
                _unitOfWork.SaveChanges();
                TempData["Message"] = "Data Created Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Search(string value)
        {
            var suppliers = string.IsNullOrEmpty(value) ? _unitOfWork.SupplierRepository.GetAll().Reverse()
                : _unitOfWork.SupplierRepository.GetAll().Reverse()
                .Where(e => e.Name.ToLower().Contains(value.ToLower()));
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = suppliers
            });
        }
        public IActionResult GetModal(int id)
        {
            return PartialView("Modal", _unitOfWork.SupplierRepository.GetByID(id));
        }
        [HttpPost]
        public IActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.SupplierRepository.Update(supplier);
                _unitOfWork.SaveChanges();
                return Json(new
                {
                    success = true
                });
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                      .Select(e => e.ErrorMessage)
                                      .ToList();
                return Json(new { success = false, errors });
            }
        }

        public IActionResult Delete(int id)
        {
            return PartialView("Delete", _unitOfWork.SupplierRepository.GetByID(id));
        }

        [HttpPost]
        public IActionResult DeleteSupplier(int id)
        {
            Supplier supplier = _unitOfWork.SupplierRepository.GetByID(id);
            if (ModelState.IsValid)
            {
                _unitOfWork.SupplierRepository.Delete(supplier);
                _unitOfWork.SaveChanges();
                TempData["Message"] = "Data Deleted Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "Hello";
                return RedirectToAction("Index");
            }

        }

    }
}