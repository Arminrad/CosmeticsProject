using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Update;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRezor.Pages.Product
{
    public class UpdateModel : PageModel
    {
        private readonly IProductService productService;

        public UpdateModel(IProductService productService)
        {
            this.productService = productService;
        }
        [BindProperty]
        public ProductInputDto productInput { get; set; }
        public void OnGet()
        {
            productInput = new ProductInputDto();
        }
        public async Task update(ProductUpdateDto productUpdateDto)
        {
            await productService.Update(productUpdateDto);
        }
    }
}

