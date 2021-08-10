using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Output;
using Cosmetics.Entities.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class SubCategoryOutputMapper:Profile
    {
        public SubCategoryOutputMapper()
        {
            CreateMap<SubCategory,SubCategoryOutputDto>();
        }
    }
}
