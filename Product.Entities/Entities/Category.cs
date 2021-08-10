using System;
using System.Collections.Generic;
using System.Text;
using Cosmetics.Entities.Entities;

namespace Cosmetics.Entities
{
    public  class Category
    { 
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<SubCategory> subCategories { get; set; }

    }
    
}
