using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace market.Models
{
    public partial class OrderItems
    {
        public int Id { get; set; }
        public int ProdId { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "must enter a positive integer for quantity")]

        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int Price { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Prod { get; set; }
    }
}
