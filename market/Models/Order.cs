using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace market.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public int Id { get; set; }
        
        [Required(ErrorMessage = "Discount is required")]
        [RegularExpression(@"^(?:[1-9][0-9]?|100|0)$", ErrorMessage = "must enter a positive integer between 0 and 100")]

        public int Discount { get; set; }
        [Required(ErrorMessage = "Tax is required")]
        [RegularExpression(@"^([1-9][0-9]?|100|0)$", ErrorMessage = "must enter a positive integer between 0 and 100")]
        public int Tax { get; set; }

        [Required(ErrorMessage = "Delivery price is required")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "must enter a positive integer")]
        public int DeliveryPrice { get; set; }

        [Required(ErrorMessage = "Delivery Address is required")]
        public string DeliveryAddress { get; set; }

        [Required(ErrorMessage = "Customer is required")]
   
        public int CustomerId { get; set; }

        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "must enter a positive integer")]
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
