using DatabaseContext.UnitOfWork.Interface;
using market.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using market.ViewModel;
using Microsoft.AspNetCore.Http;

namespace web.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly projectDBContext _projectDBContex;

        public ProductsController(IUnitOfWork unitOfWork, projectDBContext projectDbContext, IWebHostEnvironment webHostEnvironment)
            : base(unitOfWork)
        {
            _webHostEnvironment = webHostEnvironment;
            _projectDBContex = projectDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProducts()
        {
            var products = _unitOfWork.ProductRepository.GetAll().Reverse();
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = products
            });
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                string fileName = UploadFile(productViewModel);
                Product product = new Product
                {
                    Id = productViewModel.Id,
                    Name = productViewModel.Name,
                    Description = productViewModel.Description,
                    Image = fileName,
                    Price = productViewModel.Price,
                    Quantity = productViewModel.Quantity,
                    AlertQuantity = productViewModel.AlertQuantity
                };
                _unitOfWork.ProductRepository.Add(product);
                _unitOfWork.SaveChanges();
                TempData["Message"] = "Data Created Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        private string UploadFile(ProductViewModel productViewModel)
        {
            string fileName = null;
            if (productViewModel.Image != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "img");
                fileName = Guid.NewGuid().ToString() + "-" + productViewModel.Image.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    productViewModel.Image.CopyTo(fileStream);
                }
            }
            return fileName;
        }

     


        public IActionResult Search(string value)
        {
            var products = string.IsNullOrEmpty(value) ? _unitOfWork.ProductRepository.GetAll().Reverse()
                : _unitOfWork.ProductRepository.GetAll().Reverse()
                .Where(e => e.Name.ToLower().Contains(value.ToLower()) ||
                e.Description.ToLower().Contains(value.ToLower()));
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = products
            });
        }


        public IActionResult GetModal(int id)
        {
            Product product = _unitOfWork.ProductRepository.GetByID(id);
            ProductViewModel productViewModel = new ProductViewModel();
            productViewModel.Id = id;
            productViewModel.Name = product.Name;
            productViewModel.Description = product.Description;
            productViewModel.Quantity = product.Quantity;
            productViewModel.Price = product.Price;
            productViewModel.AlertQuantity = product.AlertQuantity;
            return PartialView("Modal", productViewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                string fileName = UploadFile(productViewModel);
                Product product = new Product
                {
                    Id = productViewModel.Id,
                    Name = productViewModel.Name,
                    Description = productViewModel.Description,
                    Image = fileName,
                    Price = productViewModel.Price,
                    Quantity = productViewModel.Quantity,
                    AlertQuantity = productViewModel.AlertQuantity
                };
                _unitOfWork.ProductRepository.Update(product);
                _unitOfWork.SaveChanges();
                TempData["Message"] = "Data Updated Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                       .Select(e => e.ErrorMessage)
                                       .ToList();
                return RedirectToAction("Index");
            }
        }
        /*  public IActionResult Edit([Bind("Id,Name,Description,Price,Quantity,AlertQuantity,fileImage")]Product product)
          {
              if (ModelState.IsValid)
              {
                  if (product.fileImage != null)
                  {
                      string newFileNmae = UploadFile1(product);
                      product.Image=newFileNmae;
                  }

                  _unitOfWork.ProductRepository.Update(product);
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
          }*/

        public IActionResult Delete(int id)
        {
            return PartialView("Delete", _unitOfWork.ProductRepository.GetByID(id));
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            Product product = _unitOfWork.ProductRepository.GetByID(id);
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductRepository.Delete(product);
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

        public IActionResult GetDetails(int id)
        {
            return PartialView("Details", _unitOfWork.ProductRepository.GetByID(id));
        }

    }
}
