using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Output;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CosmeticsRazor.Pages.Product
{
    public class GetAllModel : PageModel
    {
        private readonly IProductService productService;

        [BindProperty]
        public List<ProductOutputDto> productOutput { get; set; }
        public GetAllModel(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task OnGet()
        {
            productOutput = new List<ProductOutputDto>();
            await productService.GetAll();
        }
    }
}