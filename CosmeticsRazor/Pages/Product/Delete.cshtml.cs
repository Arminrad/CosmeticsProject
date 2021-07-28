using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRazor.Pages.Product
{
    public class DeleteModel : PageModel
    {
        private readonly IProductService productService;

        [BindProperty]
        public ProductInputDto productInput { get; set; }
        public DeleteModel(IProductService productService)
        {
            this.productService = productService;
        }
     
        public void OnGet()
        {
            productInput = new ProductInputDto();
        }
        public async Task Delete(int id)
        {
            await productService.Delete(id);
        }
    }
}