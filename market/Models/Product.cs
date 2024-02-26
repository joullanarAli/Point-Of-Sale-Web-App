using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace market.Models
{
    public partial class Product
    {
        public Product()
        {
            EntryItems = new HashSet<EntryItems>();
            OrderItems = new HashSet<OrderItems>();
        }
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name is long")]
        [RegularExpression(@"^([a-zA-Z]| )+$", ErrorMessage = "the name must be only letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [RegularExpression(@"^(?=.*[a-zA-Z]).+$", ErrorMessage = "the description can't be only numbers")] 
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "must enter a positive integer")]
        public int Price { get; set; }

        public string Image { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "must enter a positive integer for quantity")]
        public int Quantity { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "must enter a positive integer for prive")]
        public int AlertQuantity { get; set; }

        public virtual ICollection<EntryItems> EntryItems { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
