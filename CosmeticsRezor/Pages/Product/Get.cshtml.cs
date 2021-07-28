using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Output;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRezor.Pages.Product
{
    public class GetModel : PageModel
    {
        private readonly IProductService productService;

        public GetModel(IProductService productService)
        {
            this.productService = productService;
        }
        [BindProperty]
        public ProductOutputDto productOutput { get; set; }
        public async Task OnGet(int id)
        {
            productOutput = new ProductOutputDto();
            await productService.Get(id);
        }

    }
}