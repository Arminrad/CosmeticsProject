using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Entities.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class SubCategoryInputMapper:Profile
    {
        public SubCategoryInputMapper()
        {
            CreateMap<SubCategoryInputMapper, SubCategory>();
        }
    }
}
