using DatabaseContext.UnitOfWork.Interface;
using market.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace web.Controllers
{
    public class CustomersController : BaseController
    {
        public CustomersController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetCustomers()
        {
            var customers = _unitOfWork.CustomerRepository.GetAll().Reverse();
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = customers
            });
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(market.Models.Customer customer)
        {
            if (ModelState.IsValid)
            {
                //customer.CreatedAt = System.DateTime.Now;
                // ViewBag.Message = "Name must be required";
                _unitOfWork.CustomerRepository.Add(customer);
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
            if (value == "VIP")
            {
                value = true.ToString();
            } else if (value == "not VIP"){
                value = false.ToString();
            }
                var customers = string.IsNullOrEmpty(value) ? _unitOfWork.CustomerRepository.GetAll().Reverse()
                : _unitOfWork.CustomerRepository.GetAll().Reverse()
                .Where(e => e.Name.ToLower().Contains(value.ToLower()) ||
                e.Address.ToLower().Contains(value.ToLower())||
                e.IsVip.ToString().ToLower().Contains(value.ToLower()));
                
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = customers
            });
        }

        public IActionResult GetModal(int id)
        {
            return PartialView("Modal", _unitOfWork.CustomerRepository.GetByID(id));
        }

        public IActionResult Edit(market.Models.Customer customer)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerRepository.Update(customer);
                _unitOfWork.SaveChanges();
                TempData["Message"] = "Data Updated Successfully";
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
            return PartialView("Delete", _unitOfWork.CustomerRepository.GetByID(id));
        }

        [HttpPost]
        public IActionResult DeleteCustomer(int id)
        {
            Customer customer = _unitOfWork.CustomerRepository.GetByID(id);
            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerRepository.Delete(customer);
                _unitOfWork.SaveChanges();
                TempData["Message"] = "Data Deleted Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        public IActionResult GetDetails(int id)
        {
            return PartialView("Details", _unitOfWork.CustomerRepository.GetByID(id));
        }
    }
}
