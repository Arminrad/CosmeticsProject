using Cosmetics.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Application.Services.SearchService
{
   public interface IProductSearch
    {

        Task<List<Product>> Search(string ProductName);
        
    }
}
