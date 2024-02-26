using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace market.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            ProductEntry = new HashSet<ProductEntry>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "name is required")]
        [StringLength(50, ErrorMessage = "Name is long")]
        [RegularExpression(@"^[a-zA-Z| ]+$", ErrorMessage = "the name must be only letters")]
        public string Name { get; set; }

        public virtual ICollection<ProductEntry> ProductEntry { get; set; }
    }
}
