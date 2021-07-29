using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRezor.Pages.Category
{
    public class UpdateModel : PageModel
    {
        private readonly ICategoryService categoryService;

        public UpdateModel(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [BindProperty]
        public CategoryUpdateDto categoryUpdateDto { get; set; }
        public void OnGet()
        {
            categoryUpdateDto = new CategoryUpdateDto();
        }
        public async Task Update(CategoryUpdateDto categoryUpdateDto)
        {
            await categoryService.Update(categoryUpdateDto);
        }
    }
}