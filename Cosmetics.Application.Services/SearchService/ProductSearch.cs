using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Application.Services.SearchService
{
    public class ProductSearch:IProductSearch
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ProductSearch(IRepositoryProduct repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }

        public async  Task<List<Product>> Search(string ProductName)
        {
            var product = await repositoryProduct.GetAllProductAsync();
            return product.Where(x => x.Name == ProductName).ToList();

        }
    }
}
