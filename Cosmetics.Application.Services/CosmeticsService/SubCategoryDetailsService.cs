using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Dto.Update;
using Cosmetics.Entities;
using Cosmetics.Entities.Entities;
using Cosmetics.Entities.IRepositories;

namespace Cosmetics.Application.Services.CosmeticsService
{
    public class SubCategoryDetailsService : ISubCategoryDetailsService
    {
        private readonly IRepositorySubCategoryDetails repositorySubCategoryDetails;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public SubCategoryDetailsService( IRepositorySubCategoryDetails repositorySubCategoryDetails, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repositorySubCategoryDetails = repositorySubCategoryDetails;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task Delete(int id)
        {
            await repositorySubCategoryDetails.DeleteAsync(id);
            await unitOfWork.Save();
        }

        public async ValueTask<SubCategoryDetailsOutputDto> Get(int id)
        {
            var output = await repositorySubCategoryDetails.GetAsync(id);
           var subcategoryDetails= mapper.Map<SubCategoryDetailsOutputDto>(output);
            return subcategoryDetails;

        }

        public async Task<List<SubCategoryDetailsOutputDto>> GetAll()
        {
            var output = await repositorySubCategoryDetails.GetAllSubCategoryDetailsAsync();
            var subcategoryDetails = mapper.Map<List<SubCategoryDetailsOutputDto>>(output);
            return subcategoryDetails;
        }

        public async Task Insert(SubCategoryDetailsInputDto subCategoryDetailsInputDto)
        {
            var input = mapper.Map<SubCategoryDetails>(subCategoryDetailsInputDto);
             repositorySubCategoryDetails.Insert(input);
            await unitOfWork.Save();
        }

        public async Task Update(SubCategoryUpdateDto subCategoryUpdateDto)
        {
            var input = new SubCategoryDetails()
            {
                Id = subCategoryUpdateDto.Id,
                SubCategoryDetailsName = subCategoryUpdateDto.SubCategoryName,
                SubCategoryId = subCategoryUpdateDto.CategoryId,

            };
             await repositorySubCategoryDetails.UpdateAsync(input);
            await unitOfWork.Save();
        }
    }
}
