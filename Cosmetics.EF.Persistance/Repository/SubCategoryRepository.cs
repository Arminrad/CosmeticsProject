using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.EF.Persistance.CosmeticsDatabase;
using Cosmetics.Entities;
using Cosmetics.Entities.Entities;
using Cosmetics.Entities.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Cosmetics.EF.Persistance.Repository
{
    public class SubCategoryRepository : IRepositorySubCategory
    {
        private readonly AppDBContext dBContext;

        public SubCategoryRepository(AppDBContext dBContext, IUnitOfWork unitOfWork)
        {
            this.dBContext = dBContext;
        }
        public async Task DeleteAsync(int id)
        {
            var subCategory = await dBContext.SubCategories.FindAsync(id);
            if (subCategory == null)
            {
                throw new KeyNotFoundException();
            }
            dBContext.SubCategories.Remove(subCategory);
        }

        public  Task<List<SubCategory>> GetAllSubCategoryAsync()
        {
            return dBContext.SubCategories.ToListAsync();
        }

        public async ValueTask<SubCategory> GetAsync(int id)
        {
            var subCategory = await dBContext.SubCategories.FindAsync(id);
            if (subCategory == null)
            {
                throw new KeyNotFoundException();
            }
            return subCategory;
        }

        public IQueryable GetQueryable()
        {
            return dBContext.SubCategories.AsQueryable();
        }

        public void Insert(SubCategory SubCategory)
        {
            dBContext.SubCategories.Add(SubCategory);
        }

        public async Task UpdateAsync(SubCategory SubCategory)
        {
            var resultsubCategory = await dBContext.SubCategories.FindAsync(SubCategory.Id);
            if (resultsubCategory == null)
            {
                throw new KeyNotFoundException();
            }
            resultsubCategory.Id = SubCategory.Id;
            resultsubCategory.SubCategoryName = SubCategory.SubCategoryName;
            resultsubCategory.CategoryId = SubCategory.CategoryId;
        }
    }
}
