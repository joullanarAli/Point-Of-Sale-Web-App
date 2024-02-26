using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace market.Models
{
    public partial class EntryItems
    {
        public int Id { get; set; }
        public int ProductEntryId { get; set; }
        public int ProdId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public virtual Product Prod { get; set; }
        public virtual ProductEntry ProductEntry { get; set; }
    }
}
