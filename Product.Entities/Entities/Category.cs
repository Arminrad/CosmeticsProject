using System.Collections.Generic;

namespace Cosmetics.Entities
{
    public  class Category
    { 
        public int Id { get; set; }
        public string CategoryName { get; set; }
        //public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }


    }
    
}
