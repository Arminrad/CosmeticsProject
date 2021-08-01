using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Dto.Update;
using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;

namespace Cosmetics.Application.Services.CosmeticsService
{
    public class StoreService : IStoreService
    {
        private readonly IRepositoryStore repositoryStore;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public StoreService(IRepositoryStore repositoryStore,IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.repositoryStore = repositoryStore;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Delete(int id)
        {
           await repositoryStore.DeleteAsync(id);
           await unitOfWork.Save();
        }

        public async ValueTask<StoreOutputDto> Get(int id)
        {
            var output= await repositoryStore.GetAsync(id);
            var store = mapper.Map<StoreOutputDto>(output);
            return store;
        }

        public async Task<List<StoreOutputDto>> GetAll()
        {
            var output = await repositoryStore.GetAllStoreAsync();
            var store = mapper.Map<List<StoreOutputDto>>(output);
            return store;
        }

        public async Task Insert(StoreInputDto storeDto)
        {
            var input = mapper.Map<Store>(storeDto);
            repositoryStore.Insert(input);
            await unitOfWork.Save();
        }

       

        public async Task Update(StoreUpdateDto storeUpdateDto)
        {
            var store = new Store()
            {
                Id = storeUpdateDto.Id,
                StoreName = storeUpdateDto.StoreName,
                Email = storeUpdateDto.Email,
                Tell = storeUpdateDto.Tell
            };
            await repositoryStore.UpdateAsync(store);
            await unitOfWork.Save();
        }
    }
}
