using System.Collections.Generic;

namespace Shop.Domain.Product
{
    public class Category
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public List<Product> Products { get; set; }
    }
}