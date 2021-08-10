using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Entities.Entities;

namespace Cosmetics.Entities.IRepositories
{
    public interface IRepositorySubCategoryDetails
    {
        void Insert(SubCategoryDetails subCategoryDetails);
        Task UpdateAsync(SubCategoryDetails subCategoryDetails);
        Task DeleteAsync(int id);
        ValueTask<SubCategoryDetails> GetAsync(int id);
        Task<List<SubCategoryDetails>> GetAllSubCategoryDetailsAsync();
        IQueryable GetQueryable();
    }
}
