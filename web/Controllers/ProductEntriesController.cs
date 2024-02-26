using DatabaseContext.UnitOfWork.Interface;
using market.Models;
using market.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace web.Controllers
{
    public class ProductEntriesController : BaseController
    {
        public ProductEntriesController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IActionResult Index()
        {
            var P_entries = _unitOfWork.ProductEntryRepository.GetAll().Reverse();
            return View(P_entries);
        }

        public IActionResult GetProductEntries()
        {
            var P_entries = _unitOfWork.ProductEntryRepository.GetAll().Reverse();
            var suppliers = _unitOfWork.SupplierRepository.GetAll();
            var supplierNames = suppliers.ToDictionary(c => c.Id, c => c.Name);
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = P_entries,
                supplierNames = supplierNames,
            });
        }

        public IActionResult Create()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<SelectListItem> list1 = new List<SelectListItem>();
            ProductEntryViewModel p_entryviewmodel = new ProductEntryViewModel();
            var suppliers = _unitOfWork.SupplierRepository.GetAll();
            var products = _unitOfWork.ProductRepository.GetAll();

            foreach (var supplier in suppliers)
            {
                list.Add(new SelectListItem
                {
                    Text = supplier.Name,
                    Value = supplier.Id.ToString()
                });
            }
            p_entryviewmodel.SupplierNames = list;

            foreach (var product in products)
            {
                list1.Add(new SelectListItem
                {
                    Text = product.Name,
                    Value = product.Id.ToString()
                });
            }
            p_entryviewmodel.ProductNames = list1;
            var p_prices = _unitOfWork.ProductRepository.GetAll().ToDictionary(p => p.Id, p => p.Price);
            p_entryviewmodel.ProductPrices = p_prices;

            return View(p_entryviewmodel);
        }

        [HttpPost]
        public IActionResult Create(ProductEntryViewModel p_entry)
        {

            if (ModelState.IsValid)
            {
                if (p_entry.SelectedProducts != null)
                {
                    var _p_entry = new ProductEntry();
                    _p_entry.SupplierId = p_entry.SupplierId;
                    _p_entry.Date = p_entry.Date;
                    _unitOfWork.ProductEntryRepository.Add(_p_entry);
                    _unitOfWork.SaveChanges();
                    for (int i = 0; i < p_entry.SelectedProducts.Count; i++)
                    {
                        var entryitems = new EntryItems();
                        entryitems.ProductEntryId = _p_entry.Id;
                        entryitems.ProdId = p_entry.SelectedProducts[i];
                        entryitems.Quantity = p_entry.quantities[i];
                        entryitems.Price = _unitOfWork.ProductRepository.GetByID(p_entry.SelectedProducts[i]).Price;
                        _unitOfWork.ProductRepository.GetByID(p_entry.SelectedProducts[i]).Quantity += p_entry.quantities[i];
                        _unitOfWork.EntryItemsRepository.Add(entryitems);
                    }

                    _unitOfWork.SaveChanges();
                    TempData["Message"] = "Data Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    List<SelectListItem> list = new List<SelectListItem>();
                    List<SelectListItem> list1 = new List<SelectListItem>();
                    ProductEntryViewModel p_entryviewmodel = new ProductEntryViewModel();
                    var suppliers = _unitOfWork.SupplierRepository.GetAll();
                    var products = _unitOfWork.ProductRepository.GetAll();

                    foreach (var supplier in suppliers)
                    {
                        list.Add(new SelectListItem
                        {
                            Text = supplier.Name,
                            Value = supplier.Id.ToString()
                        });
                    }
                    p_entryviewmodel.SupplierNames = list;

                    foreach (var product in products)
                    {
                        list1.Add(new SelectListItem
                        {
                            Text = product.Name,
                            Value = product.Id.ToString()
                        });
                    }
                    p_entryviewmodel.ProductNames = list1;
                    var p_prices = _unitOfWork.ProductRepository.GetAll().ToDictionary(p => p.Id, p => p.Price);
                    p_entryviewmodel.ProductPrices = p_prices;
                    TempData["Message"] = "please choose the products";

                    return View(p_entryviewmodel);
                   
                   
                }

            }
            else
            {
                List<SelectListItem> list = new List<SelectListItem>();
                List<SelectListItem> list1 = new List<SelectListItem>();
                ProductEntryViewModel p_entryviewmodel = new ProductEntryViewModel();
                var suppliers = _unitOfWork.SupplierRepository.GetAll();
                var products = _unitOfWork.ProductRepository.GetAll();

                foreach (var supplier in suppliers)
                {
                    list.Add(new SelectListItem
                    {
                        Text = supplier.Name,
                        Value = supplier.Id.ToString()
                    });
                }
                p_entryviewmodel.SupplierNames = list;

                foreach (var product in products)
                {
                    list1.Add(new SelectListItem
                    {
                        Text = product.Name,
                        Value = product.Id.ToString()
                    });
                }
                p_entryviewmodel.ProductNames = list1;
                var p_prices = _unitOfWork.ProductRepository.GetAll().ToDictionary(p => p.Id, p => p.Price);
                p_entryviewmodel.ProductPrices = p_prices;

                return View(p_entryviewmodel);
            }
        }

        public IActionResult Details(int id)
        {
            ProductEntry p_entry = _unitOfWork.ProductEntryRepository.GetByID(id);
            return View(p_entry);
        }

        public IActionResult Search(string value)
        {
            var productEntries = string.IsNullOrEmpty(value) ? _unitOfWork.ProductEntryRepository.GetAll().Reverse()
                : _unitOfWork.ProductEntryRepository.GetAll().Reverse()
                .Where(e => _unitOfWork.SupplierRepository.GetByID(e.SupplierId).Name.ToString().ToLower().Contains(value.ToLower())||
                e.Date.ToString().Contains(value));
            var suppliers = _unitOfWork.SupplierRepository.GetAll();
            var supplierNames = suppliers.ToDictionary(c => c.Id, c => c.Name);
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = productEntries,
                supplierNames = supplierNames,
            });
        }


        public IActionResult GetModal(int id)
        {
            var suppliers = _unitOfWork.SupplierRepository.GetAll().Reverse();
            ViewBag.Suppliers = suppliers;
            return PartialView("Modal", _unitOfWork.ProductEntryRepository.GetByID(id));
        }
        [HttpPost]
        public IActionResult Edit(ProductEntry productEntry)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ProductEntryRepository.Update(productEntry);
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
            return PartialView("Delete", _unitOfWork.ProductEntryRepository.GetByID(id));
        }

        [HttpPost]
        public IActionResult DeleteProductEntry(int id)
        {
            ProductEntry productEntry = _unitOfWork.ProductEntryRepository.GetByID(id);
            var entry_items = _unitOfWork.EntryItemsRepository.GetAll().Where(e => e.ProductEntryId == id).ToList();
            if(entry_items.Count==0)
            {
                ProductEntry p_entry = _unitOfWork.ProductEntryRepository.GetByID(id);
                _unitOfWork.ProductEntryRepository.Delete(p_entry);
                _unitOfWork.SaveChanges();
                TempData["Message"] = "Data Deleted Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "can't delete product entry untill deleting all the entry items in it!";
                return RedirectToAction("Index");
            }

        }
        public IActionResult GetProductEntryProducts(ProductEntry p_entry)
        {
            var entryitems = _unitOfWork.EntryItemsRepository.GetAllWithProducts().Where(e => e.ProductEntryId.Equals(p_entry.Id)).Reverse();
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = entryitems
            });
        }
        public IActionResult GetItemModal(int id)
        {
            return PartialView("ItemModal", _unitOfWork.EntryItemsRepository.GetByID(id));
        }

        [HttpPost]
        public IActionResult EditItem(EntryItems item, int old_quantity)
        {
            if (item.Quantity >= 0 && old_quantity >= item.Quantity)
            {
                _unitOfWork.EntryItemsRepository.Update(item);
                _unitOfWork.ProductRepository.GetByID(item.ProdId).Quantity -= old_quantity - item.Quantity;
                _unitOfWork.SaveChanges();
                TempData["Message"] = "Data Updated Successfully";
                return RedirectToAction("Details", new { id = item.ProductEntryId });
            }
            else
            {
                TempData["Message"] = "update failed 'invalid quantity'enter a positive integer less than the old one! ";
                return RedirectToAction("Details", new { id = item.ProductEntryId });
            }

        }
        public IActionResult DeleteItemModal(int id)
        {
            return PartialView("DeleteItem", _unitOfWork.EntryItemsRepository.GetByID(id));
        }

        [HttpPost]
        public IActionResult DeleteItem(int id)
        {


            EntryItems p_entry = _unitOfWork.EntryItemsRepository.GetByID(id);
            int p_entryID = p_entry.ProductEntryId;
            _unitOfWork.ProductRepository.GetByID(p_entry.ProdId).Quantity -= p_entry.Quantity;
            _unitOfWork.EntryItemsRepository.Delete(p_entry);
            _unitOfWork.SaveChanges();
            var p_entry_items = _unitOfWork.EntryItemsRepository.GetAll().Where(o => o.ProductEntryId == p_entryID).ToList();
            if (p_entry_items.Count == 0)
            {
                _unitOfWork.ProductEntryRepository.Delete(_unitOfWork.ProductEntryRepository.GetByID(p_entryID));
                _unitOfWork.SaveChanges();
                TempData["Message"] = "product entry Deleted because you delete all the items";
                return Redirect("Index");
            }
            else
            {
                TempData["Message"] = "Item deleted successfully";
                return RedirectToAction("Details", new { id = p_entryID });
            }



        }
        public IActionResult GetDetails(int id)
        {
            return PartialView("orderDetails", _unitOfWork.ProductEntryRepository.GetByID(id));
        }


    }

}

