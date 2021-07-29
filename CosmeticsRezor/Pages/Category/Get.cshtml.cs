using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Output;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRezor.Pages.Category
{
    public class GetModel : PageModel
    {
        private readonly ICategoryService categoryService;

        public GetModel(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [BindProperty]
        public CategoryOutputDto categoryOutputDto { get; set; }

        public async Task OnGet(int id)
        {
            categoryOutputDto = new CategoryOutputDto();
            await categoryService.Get(id);
        }
    }
}