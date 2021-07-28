using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRazor.Pages.Product
{
    public class GetModel : PageModel
    {
        private readonly IProductService productService;

        [BindProperty]
        public ProductOutputDto productOutput { get; set; }
        public GetModel(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task OnGet(int id)
        {
            productOutput = new ProductOutputDto();
            await productService.Get(id);
        }
      
    }
}