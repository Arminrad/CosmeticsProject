using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.EF.Persistance.CosmeticsDatabase;
using Cosmetics.Entities;
using Cosmetics.Entities.Entities;
using Cosmetics.Entities.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Cosmetics.EF.Persistance.Repository
{
    public class SubCategoryDetailsRepository:IRepositorySubCategoryDetails
    {
        private readonly AppDBContext dBContext;

        public SubCategoryDetailsRepository(AppDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task DeleteAsync(int id)
        {
            var subcategoryDetails=await dBContext.subCategoryDetails.FindAsync(id);
            if (subcategoryDetails == null)
            {
                throw new KeyNotFoundException();
            }
            dBContext.subCategoryDetails.Remove(subcategoryDetails);
        }

        public async Task<List<SubCategoryDetails>> GetAllSubCategoryDetailsAsync()
        {
            return await dBContext.subCategoryDetails.ToListAsync();
        }

        public async ValueTask<SubCategoryDetails> GetAsync(int id)
        {
            var subcategoryDetails = await dBContext.subCategoryDetails.FindAsync(id);
            if (subcategoryDetails==null)
            {
                throw new KeyNotFoundException();
            }
            return subcategoryDetails;
           
        }

        public IQueryable GetQueryable()
        {
            return dBContext.subCategoryDetails.AsQueryable();
        }

        public void Insert(SubCategoryDetails subCategoryDetails)
        {
            dBContext.subCategoryDetails.Add(subCategoryDetails);
        }

        public async Task UpdateAsync(SubCategoryDetails subCategoryDetails)
        {
            var resultSubCategoryDetails =await dBContext.subCategoryDetails.FindAsync(subCategoryDetails.Id);
            if(resultSubCategoryDetails==null)
            {
                throw new KeyNotFoundException();
            }
            resultSubCategoryDetails.SubCategoryId = subCategoryDetails.SubCategoryId;
            resultSubCategoryDetails.SubCategoryDetailsName = subCategoryDetails.SubCategoryDetailsName;
        }
    }
}
