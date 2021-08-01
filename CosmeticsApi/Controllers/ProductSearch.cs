using Cosmetics.Application.Services.SearchService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmeticsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSearch : ControllerBase
    {
        private readonly IProductSearch productSearch;

        public ProductSearch(IProductSearch productSearch)
        {
            this.productSearch = productSearch;
        }

        [HttpGet("{Name}")]

        public async Task<IActionResult> Search(string Name)
        {
          var product=await  productSearch.Search(Name);
            return Ok(product);

        }
    }
}
