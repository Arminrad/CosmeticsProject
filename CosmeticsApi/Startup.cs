using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmetics.Application.Services.CosmeticsService;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Application.Services.Mapper;
using Cosmetics.EF.Persistance.CosmeticsDatabase;
using Cosmetics.EF.Persistance.Repository;
using Cosmetics.Entities;
using Cosmetics.Entities.IRepositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace CosmeticsApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(ICategoryService), typeof(CategoryService));
            services.AddScoped(typeof(ICommentService), typeof(CommentService));
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(IStoreService), typeof(StoreService));
            services.AddScoped(typeof(IRepositoryCategory), typeof(CategoryRepository));
            services.AddScoped(typeof(IRepositoryComment), typeof(CommentRepository));
            services.AddScoped(typeof(IRepositoryProduct), typeof(ProductRepository));
            services.AddScoped(typeof(IRepositoryStore), typeof(StoreRepository));
            services.AddScoped(typeof(IRepositoryUser), typeof(UserRepository));
            services.AddAutoMapper(typeof(ProductInputMapper));
            services.AddAutoMapper(typeof(ProductOutputMapper));
            services.AddAutoMapper(typeof(CategoryInputMapper));
            services.AddAutoMapper(typeof(CategoryOutputDto));
            services.AddAutoMapper(typeof(StoreInputMapper));
            services.AddAutoMapper(typeof(StoreOutputDto));
            services.AddAutoMapper(typeof(UserInputMapper));
            services.AddAutoMapper(typeof(UserOutputDto));
            services.AddAutoMapper(typeof(CommentInputMapper));
            services.AddAutoMapper(typeof(CommentOutputMapper));


            services.AddDbContext<AppDBContext>
            (o => o.UseSqlServer(Configuration.GetConnectionString("CosmeticsDb")));
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

      
  
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "My API V1");
            });
        }
    }
}
