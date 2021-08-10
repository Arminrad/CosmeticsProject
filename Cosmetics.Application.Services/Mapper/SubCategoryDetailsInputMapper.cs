﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Cosmetics.Application.Services.Dto.Input;
using Cosmetics.Entities.Entities;

namespace Cosmetics.Application.Services.Mapper
{
    public class SubCategoryDetailsInputMapper:Profile
    {
        public SubCategoryDetailsInputMapper()
        {
            CreateMap<SubCategoryDetailsInputDto, SubCategoryDetails>();
        }
    }
}
