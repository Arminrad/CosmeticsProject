using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Output;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRezor.Pages.Partial
{
    public class MenuPartialModel : PageModel
    {
        private readonly ICategoryService categoryService;

        public MenuPartialModel(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [BindProperty]
        public List<CategoryOutputDto> CategoryOutput { get; set; }
        public async Task OnGet()
        {
            CategoryOutput = new List<CategoryOutputDto>();
            CategoryOutput = await categoryService.GetAll();
        }
    }
}