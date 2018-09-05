using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Shop.Domain.Identity
{
    public class User : IdentityUser<Guid,UserLogins,UserRoles,UserClaims>
    {
        public string Address { get; set; }

        public virtual List<Product.Product> Product { get; set; }
    }
}