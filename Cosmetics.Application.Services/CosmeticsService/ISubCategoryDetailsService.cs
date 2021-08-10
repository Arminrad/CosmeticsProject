using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Dto.Update;

namespace Cosmetics.Application.Services.CosmeticsService
{
    public interface ISubCategoryDetailsService
    {

        Task Insert(SubCategoryDetailsInputDto subCategoryDetailsInputDto);
        Task Delete(int id);
        Task Update(SubCategoryUpdateDto subCategoryUpdateDto);
        ValueTask<SubCategoryDetailsOutputDto> Get(int id);
        Task<List<SubCategoryDetailsOutputDto>> GetAll();
    }
}
