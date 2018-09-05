using System.Collections.Generic;
using System.Security.AccessControl;
using Shop.Domain.Identity;

namespace Shop.Domain.Product
{
    public class Product
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }       

        public virtual List<User> Users { get; set; }
    }
}