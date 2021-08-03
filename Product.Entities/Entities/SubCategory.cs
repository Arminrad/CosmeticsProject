using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Entities.Entities
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string SubCategoryName { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<SubCategoryDetails> SubCategoryDetails { get; set; }
    }
}
