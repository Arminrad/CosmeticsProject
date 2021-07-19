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
    public class createModel : PageModel
    {
        private readonly IProductService product;

        public createModel(IProductService product)
        {
            this.product = product;
        }
        [BindProperty]
        public ProductInputDto ProductInput { get; set; }
        public void OnGet()
        {
            ProductInput = new ProductInputDto();
        }
        public Task Onpost()
        {
            product.Insert(ProductInput);
        }
    }
}
