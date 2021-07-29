using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRezor.Pages.Category
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryService categoryService;

        public CreateModel(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        [BindProperty]
        public CategoryInputDto categoryInputDto { get; set; }
        public void OnGet()
        {
            categoryInputDto = new CategoryInputDto();
        }
        public async Task insert()
        {
            await categoryService.Insert(categoryInputDto);
        }
    }
}