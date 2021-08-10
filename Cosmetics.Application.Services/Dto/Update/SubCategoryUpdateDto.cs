using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Application.Services.Dto.Update
{
    public class SubCategoryUpdateDto
    {
        public int Id { get; set; }
        public string SubCategoryName { get; set; }
        
        public int CategoryId { get; set; }
    }
}
