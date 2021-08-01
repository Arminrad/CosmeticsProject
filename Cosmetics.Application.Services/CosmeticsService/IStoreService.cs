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
    public interface IStoreService
    {
        Task Insert(StoreInputDto storeDto);
        Task Delete(int id);
        Task Update(StoreUpdateDto storeUpdateDto);
        ValueTask<StoreOutputDto> Get(int id);
        Task<List<StoreOutputDto>> GetAll();
    }
}
