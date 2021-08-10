using System;
using System.Collections.Generic;
using System.Text;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Dto.Input
{
    public class SubCategoryInputDto
    {
        public string SubCategoryName { get; set; }
       
        public int CategoryId { get; set; }
    }
}
