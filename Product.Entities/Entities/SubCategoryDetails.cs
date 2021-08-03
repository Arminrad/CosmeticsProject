using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Entities.Entities
{
    public class SubCategoryDetails
    {
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategoryDetailsName { get; set; }
        public SubCategory SubCategory { get; set; }
        public List<Product> Products { get; set; }
    }
}
