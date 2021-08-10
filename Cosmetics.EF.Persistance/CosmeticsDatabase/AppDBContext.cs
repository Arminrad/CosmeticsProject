using System;
using System.Collections.Generic;
using System.Text;
using Cosmetics.Entities;
using Cosmetics.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cosmetics.EF.Persistance.CosmeticsDatabase
{
    public class AppDBContext : DbContext
    {
        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreProduct> StoreProducts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> UserComments { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubCategoryDetails> subCategoryDetails { get; set; }
        public AppDBContext()
        {

        }
        public AppDBContext(DbContextOptions<AppDBContext> options)
            :base(options)
        {

        }
    }
}
