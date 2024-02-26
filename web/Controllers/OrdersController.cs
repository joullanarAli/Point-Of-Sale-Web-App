using DatabaseContext.UnitOfWork.Interface;
using market.Models;
using market.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace web.Controllers
{
    public class OrdersController : BaseController
    {
        public OrdersController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IActionResult Index()
        {
            var orders = _unitOfWork.OrderRepository.GetAllWithCustomers();
            return View(orders);
        }
        public IActionResult GetOrders()
        {
            var orders = _unitOfWork.OrderRepository.GetAll().Reverse();
            foreach (var order in orders)
            {
                order.Customer = _unitOfWork.CustomerRepository.GetByID(order.CustomerId);
            }
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = orders
            });

        }
        public IActionResult Create()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            List<SelectListItem> list1 = new List<SelectListItem>();
            OrderViewModel orderViewModel = new OrderViewModel();
            var customers = _unitOfWork.CustomerRepository.GetAll();
            var products = _unitOfWork.ProductRepository.GetAll();


            foreach (var customer in customers)
            {
                list.Add(new SelectListItem
                {
                    Text = customer.Name,
                    Value = customer.Id.ToString()
                });
            }
            orderViewModel.CustomerNames = list;
            foreach (var product in products)
            {
                list1.Add(new SelectListItem
                {
                    Text = product.Name,
                    Value = product.Id.ToString()
                });
            }
            orderViewModel.ProductNames = list1;
            var p_prices = _unitOfWork.ProductRepository.GetAll().ToDictionary(p => p.Id, p => p.Price);
            orderViewModel.ProductPrices = p_prices;

            return View(orderViewModel);
        }

        [HttpPost]
        public IActionResult Create(OrderViewModel order)
        {

            if (ModelState.IsValid)
            {
                if (order.SelectedProducts != null)
                {
                    var _order = new Order();
                    _order.CustomerId = order.CustomerId;
                    _order.OrderDate = order.OrderDate;
                    _order.TotalPrice = order.TotalPrice;
                    _order.DeliveryAddress = order.DeliveryAddress;
                    _order.DeliveryPrice = order.DeliveryPrice;
                    _order.Discount = order.Discount;
                    _order.Tax = order.Tax;
                    _unitOfWork.OrderRepository.Add(_order);
                    _unitOfWork.SaveChanges();
                    for (int i = 0; i < order.SelectedProducts.Count; i++)
                    {
                        var OrderItem = new OrderItems();
                        OrderItem.OrderId = _order.Id;
                        OrderItem.ProdId = order.SelectedProducts[i];
                        OrderItem.Quantity = order.quantities[i];
                        OrderItem.Price = _unitOfWork.ProductRepository.GetByID(order.SelectedProducts[i]).Price;
                        _unitOfWork.ProductRepository.GetByID(order.SelectedProducts[i]).Quantity -= order.quantities[i];
                        _unitOfWork.OrderItemsRepository.Add(OrderItem);
                    }
                    _unitOfWork.SaveChanges();
                    TempData["Message"] = "Data Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    List<SelectListItem> list = new List<SelectListItem>();
                    List<SelectListItem> list1 = new List<SelectListItem>();
                    OrderViewModel orderViewModel = new OrderViewModel();
                    var customers = _unitOfWork.CustomerRepository.GetAll();
                    var products = _unitOfWork.ProductRepository.GetAll();

                    foreach (var customer in customers)
                    {
                        list.Add(new SelectListItem
                        {
                            Text = customer.Name,
                            Value = customer.Id.ToString()
                        });
                    }
                    orderViewModel.CustomerNames = list;
                    foreach (var product in products)
                    {
                        list1.Add(new SelectListItem
                        {
                            Text = product.Name,
                            Value = product.Id.ToString()
                        });
                    }
                    orderViewModel.ProductNames = list1;
                    TempData["Message"] = "please choose/rechoose the products";
                    var p_prices = _unitOfWork.ProductRepository.GetAll().ToDictionary(p => p.Id, p => p.Price);
                    orderViewModel.ProductPrices = p_prices;
                    return View(orderViewModel);
                }

            }
            else
            {
                List<SelectListItem> list = new List<SelectListItem>();
                List<SelectListItem> list1 = new List<SelectListItem>();
                OrderViewModel orderViewModel = new OrderViewModel();
                var customers = _unitOfWork.CustomerRepository.GetAll();
                var products = _unitOfWork.ProductRepository.GetAll();

                foreach (var customer in customers)
                {
                    list.Add(new SelectListItem
                    {
                        Text = customer.Name,
                        Value = customer.Id.ToString()
                    });
                }
                orderViewModel.CustomerNames = list;
                foreach (var product in products)
                {
                    list1.Add(new SelectListItem
                    {
                        Text = product.Name,
                        Value = product.Id.ToString()
                    });
                }
                orderViewModel.ProductNames = list1;
                var p_prices = _unitOfWork.ProductRepository.GetAll().ToDictionary(p => p.Id, p => p.Price);
                orderViewModel.ProductPrices = p_prices;
                return View(orderViewModel);
            }
        }
        public IActionResult Search(string value)
        {
            var orders = string.IsNullOrEmpty(value) ? _unitOfWork.OrderRepository.GetAllWithCustomers()
                : _unitOfWork.OrderRepository.GetAllWithCustomers()
                .Where(e => e.Customer.Name.ToLower().Contains(value.ToLower()) ||
                e.DeliveryAddress.ToLower().Contains(value.ToLower()) ||
                e.OrderDate.ToString().ToLower().Contains(value.ToLower()));
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = orders
            });
        }



        public IActionResult GetModal(int id)
        {
            return PartialView("Modal", _unitOfWork.OrderRepository.GetByID(id));
        }
        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.OrderRepository.Update(order);
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
            return PartialView("Delete", _unitOfWork.OrderRepository.GetByID(id));
        }

        [HttpPost]
        public IActionResult DeleteOrder(int id)
        {
            var order_items = _unitOfWork.OrderItemsRepository.GetAll().Where(o => o.OrderId == id).ToList();
            if (order_items.Count == 0)
            {
               
                    Order order = _unitOfWork.OrderRepository.GetByID(id);
                    _unitOfWork.OrderRepository.Delete(order);
                    _unitOfWork.SaveChanges();
                    TempData["Message"] = "Data Deleted Successfully";
                    return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "can't delete order untill deleting all the items in it!";
                return RedirectToAction("Index");
            }


        }
        public IActionResult Details(int id)
        {
            Order order = _unitOfWork.OrderRepository.GetByID(id);
            return View(order);
        }
        
        public IActionResult GetOrderProducts(Order order)
        {
            var orderItems = _unitOfWork.OrderItemsRepository.GetAllWithProducts().Where(e => e.OrderId.Equals(order.Id)).Reverse();
            return Json(new
            {
                success = true,
                message = "All Data is back",
                data = orderItems
            });
        }
        public IActionResult GetItemModal(int id)
        {
            return PartialView("ItemModal", _unitOfWork.OrderItemsRepository.GetByID(id));
        }

        [HttpPost]
        public IActionResult EditItem(OrderItems item,int old_quantity)
        {
                if(item.Quantity>=0 && old_quantity>=item.Quantity)
                {
                    _unitOfWork.OrderItemsRepository.Update(item);
                    _unitOfWork.ProductRepository.GetByID(item.ProdId).Quantity += old_quantity-item.Quantity;
                    _unitOfWork.SaveChanges();
                    TempData["Message"] = "Data Updated Successfully";
                    return RedirectToAction("Details", new { id = item.OrderId });
                }
                else
                {
                    TempData["Message"] = "update failed 'invalid quantity'enter a positive integer less than the old one! ";
                    return RedirectToAction("Details", new { id = item.OrderId });
                }

        }
        public IActionResult DeleteItemModal(int id)
        {
            return PartialView("DeleteItem", _unitOfWork.OrderItemsRepository.GetByID(id));
        }

        [HttpPost]
        public IActionResult DeleteItem(int id)
        {
            
                
                    OrderItems order = _unitOfWork.OrderItemsRepository.GetByID(id);
                    int orderID = order.OrderId;
                    _unitOfWork.ProductRepository.GetByID(order.ProdId).Quantity += order.Quantity;
                    _unitOfWork.OrderItemsRepository.Delete(order);
                    _unitOfWork.SaveChanges();
                    var order_items = _unitOfWork.OrderItemsRepository.GetAll().Where(o => o.OrderId == orderID).ToList();
            if (order_items.Count==0)
                {
                    _unitOfWork.OrderRepository.Delete(_unitOfWork.OrderRepository.GetByID(orderID));
                    _unitOfWork.SaveChanges();
                    TempData["Message"] = "Order Deleted because you delete all the items";
                return Redirect("Index");
                }
                else
                {
                TempData["Message"] = "Item deleted successfully";
                return RedirectToAction("Details", new { id = orderID });
                }
                    
                
               
        }
        public IActionResult GetDetails(int id)
        {
            return PartialView("orderDetails", _unitOfWork.OrderRepository.GetByID(id));
        }


    }
}

