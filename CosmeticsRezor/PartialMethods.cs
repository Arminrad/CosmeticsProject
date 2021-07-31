using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticsRezor
{
    public class PartialMethods
    {
        private readonly ICategoryService categoryService;

        public PartialMethods(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

       
    }
}
