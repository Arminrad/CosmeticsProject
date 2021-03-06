using System.Collections.Generic;

namespace Cosmetics.Entities
{
    public class Product
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Comment { get; set; }
        public string Country { get; set; }
        public double Weight { get; set; }
        public List<StoreProduct> StoreProducts { get; set; }
        public List<Comment> UserComments { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
