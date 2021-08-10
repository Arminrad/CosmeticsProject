using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Entities.Entities;

namespace Cosmetics.Entities.IRepositories
{
    public  interface IRepositorySubCategory
    {

        void Insert(SubCategory SubCategory);
        Task UpdateAsync(SubCategory SubCategory);
        Task DeleteAsync(int id);
        ValueTask<SubCategory> GetAsync(int id);
        Task<List<SubCategory>> GetAllSubCategoryAsync();
        IQueryable GetQueryable();
    }
}
