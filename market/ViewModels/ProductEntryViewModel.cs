using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace market.ViewModels
{
    public class ProductEntryViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "supplier is required!")]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Date is required!")]
        public DateTime Date { get; set; }
        public List<SelectListItem> ProductNames { get; set; }
        public Dictionary<int, int> ProductPrices { get; set; }
        public List<int> SelectedProducts { get; set; }
        public List<int> quantities { get; set; }
        public List<SelectListItem> SupplierNames { get; set; }

    }
}
