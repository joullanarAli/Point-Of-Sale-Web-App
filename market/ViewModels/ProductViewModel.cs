using DatabaseContext.UnitOfWork.Interface;
using market.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
namespace market.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name is long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "must enter a number (positive)")]
        public int Price { get; set; }

        public IFormFile Image { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "must enter a positive integer")]
        public int Quantity { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "must enter a positive integer")]
        public int AlertQuantity { get; set; }

        public virtual ICollection<EntryItems> EntryItems { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }

    }
}
