using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace market.Models
{
    public class ApplicationUser : IdentityUser<String>
    {
        public virtual Customer Customer { get; set; }
    }
}
