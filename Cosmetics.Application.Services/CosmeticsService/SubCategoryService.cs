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
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IRepositorySubCategory repositorySubCategory;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public SubCategoryService(IRepositorySubCategory repositorySubCategory, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repositorySubCategory = repositorySubCategory;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task Delete(int id)
        {
            await repositorySubCategory.DeleteAsync(id);
            await unitOfWork.Save();
        }

        public async ValueTask<SubCategoryOutputDto> Get(int id)
        {

            var output = await repositorySubCategory.GetAsync(id);
            var subCategory = mapper.Map<SubCategoryOutputDto>(output);
            return subCategory;
        }

        public async Task<List<SubCategoryOutputDto>> GetAll()
        {
            var output = await repositorySubCategory.GetAllSubCategoryAsync();
            var subCategory = mapper.Map<List<SubCategoryOutputDto>>(output);
            return subCategory;
        }

        public  async Task Insert(SubCategoryInputDto subCategoryInputDto)
        {
            var input = mapper.Map<SubCategory>(subCategoryInputDto);
            repositorySubCategory.Insert(input);
            await unitOfWork.Save();
        }

        public async Task Update(SubCategoryUpdateDto subCategoryUpdateDto)
        {
            var input = new SubCategory()
            {
                Id = subCategoryUpdateDto.Id,
                SubCategoryName=subCategoryUpdateDto.SubCategoryName,
                CategoryId=subCategoryUpdateDto.CategoryId
            };
            await repositorySubCategory.UpdateAsync(input);
            await unitOfWork.Save();
        }
    }
}
