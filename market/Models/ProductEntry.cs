using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace market.Models
{
    public partial class ProductEntry
    {
        public ProductEntry()
        {
            EntryItems = new HashSet<EntryItems>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage ="supplier is required!")]
        public int SupplierId { get; set; }

        [Required(ErrorMessage ="Date is required!")]
        public DateTime Date { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<EntryItems> EntryItems { get; set; }
    }
}
