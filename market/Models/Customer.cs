using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace market.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }


        public Boolean IsVip { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email  is required")]
        [RegularExpression(@"^[\w-_.]+@[\w-_]+\.[\w]+$", ErrorMessage = "invalid syntax for an email ")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "name is required")]
        [StringLength(50, ErrorMessage = "Name is long")]
        [RegularExpression(@"^[a-zA-Z| ]+$", ErrorMessage = "the name must be only letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "phone number is required")]
        [RegularExpression(@"^09\d{8}$", ErrorMessage = "The number must be of the form 09********.")]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
