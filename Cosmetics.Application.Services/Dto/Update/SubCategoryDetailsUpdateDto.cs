using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmetics.Application.Services.Dto.Update
{
    public class SubCategoryDetailsUpdateDto
    {
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        public string SubCategoryDetailsName { get; set; }
    }
}
