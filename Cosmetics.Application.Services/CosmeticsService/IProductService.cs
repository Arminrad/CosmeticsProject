using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Dto.Update;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.CosmeticsService
{
   public  interface IProductService
    {
        Task Insert(ProductInputDto productDto);
        Task Delete(int id);
        Task Update(ProductUpdateDto productUpdateDto);
        ValueTask<ProductOutputDto> Get(int id);
        Task<List<ProductOutputDto>> GetAll();    
   }
}
