using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class CategoryInputMapper:Profile
    {
        public CategoryInputMapper()
        {
            CreateMap<CategoryInputDto,Category>();
        }
       
    }
}
