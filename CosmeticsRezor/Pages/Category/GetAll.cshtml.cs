using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Mapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRezor.Pages.Category
{
    public class GetAllModel : PageModel
    {
        private readonly ICategoryService categoryService;

        public GetAllModel(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [BindProperty]
        public CategoryOutputDto  CategoryOutput { get; set; }
        public async Task OnGet()
        {
            await categoryService.GetAll();
        }
    }
}